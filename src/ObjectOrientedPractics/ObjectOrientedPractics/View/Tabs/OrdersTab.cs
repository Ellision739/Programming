using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
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
        /// Возвращает и задаёт список заказов.
        /// </summary>
        public List<Order> Orders { get; set; }

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

        public OrdersTab()
        {
            InitializeComponent();
            Orders = new List<Order>();
            // ReadOnly для полей адреса
            addressControl.AddressReadOnlyTrue();

            // Костыль для TimeComboBox
            var deliveryList = deliveryTimeNames
                .Select(kv => new { Key = kv.Key, Value = kv.Value })
                .ToList();

            DeliveryTimeComboBox.DisplayMember = "Value";
            DeliveryTimeComboBox.ValueMember = "Key";
            DeliveryTimeComboBox.DataSource = deliveryList;
        }

        /// <summary>
        /// Обновляет таблицу заказов при инициализации.
        /// </summary>
        public void UpdateOrders()
        {
            Orders.Clear();

            foreach (var customer in Customers)
            {
                if (customer.Orders != null)
                {
                    foreach (var order in customer.Orders)
                    {
                        Orders.Add(order);
                    }
                }
            }

            OrdersDataGridView.DataSource = null; // сбрасываем старую привязку
            OrdersDataGridView.DataSource = Orders;

            // Обработка Fullname в таблице
            for (int i = 0; i < Orders.Count; i++)
            {
                var order = Orders[i];
                var customer = Customers.FirstOrDefault(c => c.Orders.Contains(order));
                if (customer != null)
                    OrdersDataGridView.Rows[i].Cells["Fullname"].Value = customer.Fullname;
            }
            // Обработка Address в таблице
            for (int i = 0; i < Orders.Count; i++)
            {
                var order = Orders[i];
                var customer = Customers.FirstOrDefault(c => c.Orders.Contains(order));
                if (customer != null)
                {
                    Address address = customer.Address;
                    string strAddress = $"{address.Index} {address.Country} {address.City} {address.Street} {address.Building} {address.Apartment}";
                    OrdersDataGridView.Rows[i].Cells["Address"].Value = strAddress;
                }
            }
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentRow == null) return;

            IDTextBox.Clear();
            CreatedTextBox.Clear();
            OrderItemsListBox.Items.Clear();
            PriorityPanel.Visible = false;

            // отображение
            IDTextBox.Text = OrdersDataGridView.CurrentRow.Cells["ID"].Value.ToString();
            CreatedTextBox.Text = OrdersDataGridView.CurrentRow.Cells["Created"].Value.ToString();
            StatusComboBox.Text = OrdersDataGridView.CurrentRow.Cells["OrderStatus"].Value.ToString();
            ValueLabel.Text = OrdersDataGridView.CurrentRow.Cells["Total"].Value.ToString();

            int selectedRowIndex = OrdersDataGridView.CurrentRow.Index;

            if (Orders[selectedRowIndex] is PriorityOrder priority)
            {
                PriorityPanel.Visible = true;
                DeliveryTimeComboBox.SelectedValue = priority.DesiredDeliveryTime;
            }
            addressControl.Address = Orders[selectedRowIndex].DeliveryAddress;
            foreach (var item in Orders[selectedRowIndex].ListOfProducts)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Orders[OrdersDataGridView.CurrentRow.Index].Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), StatusComboBox.SelectedItem.ToString());
            OrdersDataGridView.CurrentRow.Cells["OrderStatus"].Value = StatusComboBox.Text;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentRow == null) return;
            if (DeliveryTimeComboBox.SelectedValue == null) return;

            var value = DeliveryTimeComboBox.SelectedValue;
            var chosen = (value is DeliveryTime) ? (DeliveryTime)value : (DeliveryTime)Enum.Parse(typeof(DeliveryTime), value.ToString());

            int index = OrdersDataGridView.CurrentRow.Index;
            if (Orders[index] is PriorityOrder priority)
            {
                priority.DesiredDeliveryTime = chosen;
            }
        }
    }
}