using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        public PriorityOrdersTab()
        {
            InitializeComponent();
            PriorityOrders = new List<PriorityOrder>();
            addressControl.AddressReadOnlyTrue();

            var deliveryList = deliveryTimeNames
                .Select(kv => new { Key = kv.Key, Value = kv.Value })
                .ToList();

            DeliveryTimeComboBox.DisplayMember = "Value";
            DeliveryTimeComboBox.ValueMember = "Key";
            DeliveryTimeComboBox.DataSource = deliveryList;
        }

        /// <summary>
        /// Текущий приоритетный заказ.
        /// </summary>
        private PriorityOrder _priorityOrder;

        /// <summary>
        /// Возвращает и задаёт приоритетный заказ.
        /// </summary>
        public PriorityOrder PriorityOrder
        {
            get { return _priorityOrder; }
            set { _priorityOrder = value; }
        }

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задаёт список приоритетных заказов.
        /// </summary>
        public List<PriorityOrder> PriorityOrders { get; set; }

        /// <summary>
        /// Словарь для красивого отображеения в TimeComboBox.
        /// </summary>
        private Dictionary<DeliveryTime, string> deliveryTimeNames = new Dictionary<DeliveryTime, string>()
        {
            { DeliveryTime.Time_9_00_11_00, "09:00–11:00" },
            { DeliveryTime.Time_11_00_13_00, "11:00–13:00" },
            { DeliveryTime.Time_13_00_15_00, "13:00–15:00" },
            { DeliveryTime.Time_15_00_17_00, "15:00–17:00" },
            { DeliveryTime.Time_17_00_19_00, "17:00–19:00" }
        };

        private void UpdateInterface()
        {
            PriorityOrdersDataGridView.DataSource = null;
            PriorityOrdersDataGridView.DataSource = PriorityOrders;


            // Устанавливаем имя покупателя
            for (int i = 0; i < PriorityOrders.Count; i++)
            {
                var order = PriorityOrders[i];
                var customer = Customers.FirstOrDefault(c => c.Orders.Contains(order));
                if (customer != null)
                    PriorityOrdersDataGridView.Rows[i].Cells["Fullname"].Value = customer.Fullname;
            }

            // Устанавливаем адрес
            for (int i = 0; i < PriorityOrders.Count; i++)
            {
                var order = PriorityOrders[i];
                var customer = Customers.FirstOrDefault(c => c.Orders.Contains(order));
                if (customer != null)
                {
                    Address address = customer.Address;
                    string strAddress = $"{address.Index} {address.Country} {address.City} {address.Street} {address.Building} {address.Apartment}";
                    PriorityOrdersDataGridView.Rows[i].Cells["Address"].Value = strAddress;
                }
            }
        }

        /// <summary>
        /// Обновляет таблицу заказов при инициализации.
        /// </summary>
        public void UpdateOrders()
        {
            PriorityOrders.Clear();

            foreach (var customer in Customers)
            {
                if (customer.Orders != null)
                {
                    foreach (var order in customer.Orders.OfType<PriorityOrder>()) // только приоритетные
                    {
                        PriorityOrders.Add(order);
                    }
                }
            }

            UpdateInterface();
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (PriorityOrdersDataGridView.CurrentRow == null) return;

            IDTextBox.Clear();
            CreatedTextBox.Clear();
            OrderItemsListBox.Items.Clear();

            // отображение
            IDTextBox.Text = PriorityOrdersDataGridView.CurrentRow.Cells["ID"].Value.ToString();
            CreatedTextBox.Text = PriorityOrdersDataGridView.CurrentRow.Cells["Created"].Value.ToString();
            StatusComboBox.Text = PriorityOrdersDataGridView.CurrentRow.Cells["OrderStatus"].Value.ToString();
            ValueLabel.Text = PriorityOrdersDataGridView.CurrentRow.Cells["TotalCost"].Value.ToString();

            int selectedRowIndex = PriorityOrdersDataGridView.CurrentRow.Index;

            DeliveryTimeComboBox.SelectedValue = PriorityOrders[selectedRowIndex].DesiredDeliveryTime;
            addressControl.Address = PriorityOrders[selectedRowIndex].DeliveryAddress;
            foreach (var item in PriorityOrders[selectedRowIndex].ListOfProducts)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PriorityOrdersDataGridView.CurrentRow == null) return;
            if (PriorityOrdersDataGridView.CurrentRow.Index < 0) return;
            if (StatusComboBox.SelectedItem == null) return;

            PriorityOrders[PriorityOrdersDataGridView.CurrentRow.Index].Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), StatusComboBox.SelectedItem.ToString());
            PriorityOrdersDataGridView.CurrentRow.Cells["OrderStatus"].Value = StatusComboBox.Text;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int index = PriorityOrdersDataGridView.CurrentRow.Index;
            int maxSizeItems = Items.Count;

            // добавление нового предмета
            PriorityOrders[index].ListOfProducts.Add(Items[rand.Next(maxSizeItems)]);
            OrderItemsListBox.Items.Clear();
            foreach (var item in PriorityOrders[index].ListOfProducts)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }

            UpdateInterface();
            ValueLabel.Text = PriorityOrdersDataGridView.CurrentRow.Cells["TotalCost"].Value.ToString();
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PriorityOrders[PriorityOrdersDataGridView.CurrentRow.Index].DesiredDeliveryTime = (DeliveryTime)Enum.Parse(typeof(DeliveryTime), DeliveryTimeComboBox.SelectedItem.ToString());
            if (PriorityOrdersDataGridView.CurrentRow == null) return;
            if (DeliveryTimeComboBox.SelectedValue == null) return;

            var value = DeliveryTimeComboBox.SelectedValue;
            var chosen = (value is DeliveryTime) ? (DeliveryTime)value : (DeliveryTime)Enum.Parse(typeof(DeliveryTime), value.ToString());

            int index = PriorityOrdersDataGridView.CurrentRow.Index;
            PriorityOrders[index].DesiredDeliveryTime = chosen;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Сначала выберите товар!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int indexRow = PriorityOrdersDataGridView.CurrentRow.Index;
            int indexList = OrderItemsListBox.SelectedIndex;
            PriorityOrders[indexRow].ListOfProducts.RemoveAt(indexList);

            UpdateInterface();
            ValueLabel.Text = PriorityOrdersDataGridView.CurrentRow.Cells["TotalCost"].Value.ToString();

            if (OrderItemsListBox.Items.Count > 0)
            {
                if (indexList >= OrderItemsListBox.Items.Count)
                {
                    indexList = OrderItemsListBox.Items.Count - 1;
                }

                OrderItemsListBox.SelectedIndex = indexList;
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            int indexRow = PriorityOrdersDataGridView.CurrentRow.Index;
            // Сохраняем данные о покупателе
            //string fullName = PriorityOrdersDataGridView.Rows[indexRow].Cells["Fullname"].Value.ToString();
            //string addressStr = PriorityOrdersDataGridView.Rows[indexRow].Cells["Address"].Value.ToString();
            Address address = PriorityOrders[indexRow].DeliveryAddress;
            Customer customer = Customers.FirstOrDefault(c => c.Orders.Contains(PriorityOrders[indexRow]));

            // Находим индекс старого заказа в списке клиента
            int orderIndex = customer.Orders.IndexOf(PriorityOrders[indexRow]);

            PriorityOrders[indexRow] = null;
            PriorityOrder newOrder = new PriorityOrder(new List<Item>(), address);

            // Заменяем в customer.Orders
            customer.Orders[orderIndex] = newOrder;
            PriorityOrders[indexRow] = newOrder;

            DeliveryTimeComboBox.SelectedIndex = 0;
            OrderItemsListBox.Items.Clear();
            ValueLabel.Text = "0";
            UpdateInterface();
            //PriorityOrdersDataGridView.Rows[indexRow].Cells["Fullname"].Value = fullName;
            //PriorityOrdersDataGridView.Rows[indexRow].Cells["Address"].Value = addressStr;
        }
    }
}