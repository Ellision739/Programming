using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле магазина со списком товаров и покупателей.
        /// </summary>
        private Store _store;
        public MainForm()
        {
            InitializeComponent();

            _store = new Store();

            // Инициализация вкладки Items
            _store.Items = itemsTab.Items;
            itemsTab.Items = _store.Items;

            // Инициализация вкладки Customers
            _store.Customers = customersTab.Customers;
            customersTab.Customers = _store.Customers;

            // Инициализация вкладки Carts
            cartsTab.Items = _store.Items;
            cartsTab.Customers = _store.Customers;

            // Инициализация вкладки Orders
            ordersTab1.Customers = _store.Customers;

            // Подписываемся на события обновления
            itemsTab.ItemsChanged += ItemsTab_ItemsChanged;
        }

        // Для гита (удалить)
        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            cartsTab.RefreshData();
            ordersTab1.UpdateOrders();
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex == 2)
            {
                cartsTab.RefreshData();
            }
            if (MainTabControl.SelectedIndex == 3)
            { 
                ordersTab1.UpdateOrders();
            }
        }
    }
}