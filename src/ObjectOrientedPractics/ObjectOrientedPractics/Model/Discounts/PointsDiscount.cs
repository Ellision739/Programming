using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Класс, представляющий накопительную скидку по бонусным баллам.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Колличество накопительных баллов.
        /// </summary>
		private int _cumulativePoints;
        /// <summary>
        /// Возвращает количество накопительных баллов. Значение всегда положительное.
        /// </summary>
		public int CumulativePoints
        {
			get { return _cumulativePoints; }
			private set 
			{
                if (value < 0)
                {
                    throw new ArgumentException("Значение должно быть положительное");
                }
                _cumulativePoints = value; 
			}
		}

        /// <summary>
        /// Возвращает информацию о скидке в виде строки:
        /// "Накопительная – {Баллы} баллов".
        /// </summary>
        public string Info
        {
            get { return $"Накопительная – {CumulativePoints} баллов"; }
        }


        /// <summary>
        /// Рассчитывает возможную скидку для списка товаров, не списывая баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер возможной скидки в рублях.</returns>
        public double Calculate(List<Item> items)
		{
            if (items == null || items.Count == 0)
            {
                return 0.0;
            }

            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }

            double maxDiscount = amount * 0.3; // максимум 30% скидки
            return Math.Min(CumulativePoints, maxDiscount);
        }

        /// <summary>
        /// Применяет скидку к списку товаров. Списывает соответствующее количество баллов.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер применённой скидки в рублях.</returns>
        public double Apply(List<Item> items)
		{
            double discount = Calculate(items);
            CumulativePoints -= (int)Math.Round(discount);
            return discount;
        }

        /// <summary>
        /// Обновляет количество баллов после покупки.
        /// Добавляет 10% от общей суммы (округляется вверх).
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
		{
            if (items == null || items.Count == 0)
            {
                return;
            }

            double amount = 0;
			foreach (Item item in items)
			{
				amount += item.Cost;
            }

            int newPoints = (int)Math.Ceiling(amount * 0.1);
            CumulativePoints += newPoints;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount()
        {
            CumulativePoints = 0;
        }


        /// <inheritdoc />
        public int CompareTo(PointsDiscount other)
        {
            if (other == null) return 1;

            return CumulativePoints.CompareTo(other.CumulativePoints);
        }
    }
}