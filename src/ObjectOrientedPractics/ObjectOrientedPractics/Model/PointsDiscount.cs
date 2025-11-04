using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий накопительную скидку по бонусным баллам.
    /// </summary>
    public class PointsDiscount
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
            int totalAmount = (int)Math.Floor(amount *= 0.3);
            if (CumulativePoints > totalAmount)
            {
                return totalAmount;
            }
            return CumulativePoints;
        }

        /// <summary>
        /// Применяет скидку к списку товаров. Списывает соответствующее количество баллов.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер применённой скидки в рублях.</returns>
        public double Apply(List<Item> items)
		{
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }
            int totalAmount = (int)Math.Floor(amount *= 0.3);
            if (CumulativePoints > totalAmount)
            {
                CumulativePoints -= totalAmount;
                return totalAmount;
            }
            totalAmount = CumulativePoints;
            CumulativePoints = 0;
            return totalAmount;
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
            CumulativePoints += (int)Math.Ceiling(amount *= 0.1);
		}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount()
        {
            CumulativePoints = 0;
        }
    }
}
