using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
	/// <summary>
	/// Описывает корзину покупателя.
	/// </summary>
    public class Cart
    {
		/// <summary>
		/// Список товаров.
		/// </summary>
		private List<Item> _listItems;
		/// <summary>
		/// Возвращает и задаёт список товаров.
		/// </summary>
		public List<Item> ListItems
		{
			get { return _listItems; }
			set { _listItems = value; }
		}
		/// <summary>
		/// Общая стоимость.
		/// </summary>
		private double _amount;
		/// <summary>
		/// Возвращает общую стоимость товаров в корзине.
		/// </summary>
		public double Amount
		{
			get 
			{
				_amount = 0.0;
				if (ListItems != null && ListItems.Count != 0)
				{
					foreach (var item in ListItems)
					{
						_amount += item.Cost;
					}
				}
				return _amount;
			}
		}

        /// <summary>
        /// Возвращает и задаёт размер примерной скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Итоговая стоимость.
        /// </summary>
        private double _total;
        /// <summary>
        /// Возвращает итоговую стоимость, после использования скидки.
        /// </summary>
        public double Total
        {
            get
            {
                _total = Amount - DiscountAmount;
                return _total;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            ListItems = new List<Item>();
        }
    }
}