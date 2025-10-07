using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ѕоле магазина со списком товаров и покупателей.
        /// </summary>
        private Store _store;
        public MainForm()
        {
            InitializeComponent();

            _store = new Store();

            _store.Items = itemsTab2.Items;
            itemsTab2.Items = _store.Items;

            _store.Customers = customersTab1.Customers;
            customersTab1.Customers = _store.Customers;
        }
    }
}
