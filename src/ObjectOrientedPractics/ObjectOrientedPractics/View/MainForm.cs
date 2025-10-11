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
            _store.Items = itemsTab2.Items;
            itemsTab2.Items = _store.Items;

            // Инициализация вкладки Customers
            _store.Customers = customersTab1.Customers;
            customersTab1.Customers = _store.Customers;

            // Инициализация вкладки Carts
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            // Инициализация вкладки Orders
            cartsTab1.Customers = _store.Customers;
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex == 2)
            {
                cartsTab1.RefreshData();
            }
        }
    }
}