using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
	/// <summary>
	/// Создаёт магазин со списком товаров и покупателей.
	/// </summary>
    public class Store
    {
		/// <summary>
		/// Список товаров.
		/// </summary>
		private List<Item> _items;
		/// <summary>
		/// Возвращает и задаёт список товаров.
		/// </summary>
		public List<Item> Items
		{
			get { return _items; }
			set { _items = value; }
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
        /// Создаёт экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
