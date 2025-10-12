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

        
        public OrdersTab()
        {
            InitializeComponent();
            Orders = new List<Order>();
            // ReadOnly для полей адреса
            addressControl.AddressReadOnlyTrue();
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

                        //OrdersDataGridView.Rows.Add(order.ID, order.DateOfCreation, order.Status, customer.Fullname, strAddress, order.TotalCost);
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
            IDTextBox.Clear();
            CreatedTextBox.Clear();
            OrderItemsListBox.Items.Clear();

            // отображение
            IDTextBox.Text = OrdersDataGridView.CurrentRow.Cells["ID"].Value.ToString();
            CreatedTextBox.Text = OrdersDataGridView.CurrentRow.Cells["Created"].Value.ToString();
            StatusComboBox.Text = OrdersDataGridView.CurrentRow.Cells["OrderStatus"].Value.ToString();
            ValueLabel.Text = OrdersDataGridView.CurrentRow.Cells["TotalCost"].Value.ToString();
            
            int selectedRowIndex = OrdersDataGridView.CurrentRow.Index;
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
    }
}
