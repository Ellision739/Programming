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
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CardsTab : UserControl
    {
        public CardsTab()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();
        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new List<Item>();

                // Сразу обновляем ListBox, чтобы всё было синхронно
                ItemsListBox.Items.Clear();
                foreach (var item in _items)
                {
                    ItemsListBox.Items.Add(item.Name);
                }
            }
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
            set
            {
                _customers = value ?? new List<Customer>();

                // Сразу обновляем ComboBox, чтобы всё было синхронно
                CustomerComboBox.Items.Clear();
                foreach (var customer in _customers)
                {
                    CustomerComboBox.Items.Add(customer.Fullname);
                }
            }
        }

        private Customer _currentCustomer;

        private Customer CurrentCustomer
        {
            get { return _currentCustomer; }
            set { _currentCustomer = value; }
        }


        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Очистка перед изменением
            CartListBox.Items.Clear();
            InfoLabel.Text = "";

            // Выбор нужного покупателя
            int customerIndex = CustomerComboBox.SelectedIndex;
            CurrentCustomer = Customers[customerIndex];

            // Отображение цены цены
            ValueLabel.Text = CurrentCustomer.Cart.Amount.ToString();

            // Отобржение в ListBox
            int items = CurrentCustomer.Cart.ListItems.Count;
            if (items > 0)
            {
                foreach (var item in CurrentCustomer.Cart.ListItems)
                {
                    CartListBox.Items.Add(item.Name);
                }
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = "";
            if (ItemsListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex != -1)
            {
                // добавляем в корзину покупателя
                int itemIndex = ItemsListBox.SelectedIndex;
                CurrentCustomer.Cart.ListItems.Add(Items[itemIndex]);

                // Отображаем в корзине покупателя
                CartListBox.Items.Add(ItemsListBox.SelectedItem);

                // Изменение цены
                ValueLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else if (ItemsListBox.SelectedIndex == -1 && CustomerComboBox.SelectedIndex != -1)
            {
                InfoLabel.Text = "Сначала выберите элемент";
            }
            else if (ItemsListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex == -1)
            {
                InfoLabel.Text = "Сначала выберите покупателя";
            }
            else
            {
                InfoLabel.Text = "Сначала выберите элемент и покупателя";
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = "";
            if (CartListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex != -1)
            {
                // извлекаем из корзины покупателя
                int cartIndex = CartListBox.SelectedIndex;
                CurrentCustomer.Cart.ListItems.RemoveAt(cartIndex);

                // Отображаем извлечение в корзине покупателя
                CartListBox.Items.RemoveAt(cartIndex);

                // Изменение цены
                ValueLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else if (CartListBox.SelectedIndex == -1 && CustomerComboBox.SelectedIndex != -1)
            {
                InfoLabel.Text = "Сначала выберите элемент";
            }
            else if (CartListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex == -1)
            {
                InfoLabel.Text = "Сначала выберите покупателя";
            }
            else
            {
                InfoLabel.Text = "Сначала выберите покупателя и элемент";
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = "";
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.ListItems.Clear();
                CartListBox.Items.Clear();

                // Изменение цены
                ValueLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else
            {
                InfoLabel.Text = "Сначала выберите покупателя";
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = "";
            if (CartListBox.Items.Count > 0 && CustomerComboBox.SelectedIndex != -1)
            {
                if (Customers[CustomerComboBox.SelectedIndex].IsPriority == false)
                {
                    // Создание нового заказа
                    Order order = new Order(CurrentCustomer.Cart.ListItems, CurrentCustomer.Address);
                    CurrentCustomer.Orders.Add(order);
                }
                else
                {
                    // Создание притетного заказа
                    PriorityOrder priorityOrder = new PriorityOrder(CurrentCustomer.Cart.ListItems, CurrentCustomer.Address);
                    CurrentCustomer.Orders.Add(priorityOrder);
                }    
                
                // Очистка корзины
                CurrentCustomer.Cart.ListItems.Clear();
                CartListBox.Items.Clear();

                // Изменение цены
                ValueLabel.Text = CurrentCustomer.Cart.Amount.ToString();

                InfoLabel.Text = "Успешно!";
            }
            else if (CartListBox.Items.Count == 0 && CustomerComboBox.SelectedIndex != -1)
            {
                InfoLabel.Text = "Сначала добавте товар в корзину";
            }
            else if (CartListBox.Items.Count > 0 && CustomerComboBox.SelectedIndex == -1)
            {
                InfoLabel.Text = "Сначала выберите покупателя";
            }
            else
            {
                InfoLabel.Text = "Сначала выберите покупателя и добавте товар в корзину";
            }
        }

        public void RefreshData()
        {
            ItemsListBox.Items.Clear();
            foreach (var item in Items)
            {
                ItemsListBox.Items.Add(item.Name);
            }

            CustomerComboBox.Items.Clear();
            foreach (var customer in Customers)
            {
                CustomerComboBox.Items.Add(customer.Fullname);
            }

            if (CurrentCustomer != null)
            {
                foreach (var itemCart in CurrentCustomer.Cart.ListItems)
                {
                    CartListBox.Items.Add(itemCart.Name);
                }

                ValueLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else
            {
                ValueLabel.Text = "0";
            }
        }

        private void PriorityOrderButton_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = "";
            if (CartListBox.Items.Count > 0 && CustomerComboBox.SelectedIndex != -1)
            {
                // Создание ПРИОРИТЕТНОГО заказа
                PriorityOrder priorityOrder = new PriorityOrder(CurrentCustomer.Cart.ListItems, CurrentCustomer.Address);
                CurrentCustomer.Orders.Add(priorityOrder);

                // Очистка корзины
                CurrentCustomer.Cart.ListItems.Clear();
                CartListBox.Items.Clear();

                // Изменение цены
                ValueLabel.Text = CurrentCustomer.Cart.Amount.ToString();

                InfoLabel.Text = "Приоритетный заказ создан!";
            }
            else if (CartListBox.Items.Count == 0 && CustomerComboBox.SelectedIndex != -1)
            {
                InfoLabel.Text = "Сначала добавте товар в корзину";
            }
            else if (CartListBox.Items.Count > 0 && CustomerComboBox.SelectedIndex == -1)
            {
                InfoLabel.Text = "Сначала выберите покупателя";
            }
            else
            {
                InfoLabel.Text = "Сначала выберите покупателя и добавте товар в корзину";
            }
        }
    }
}
