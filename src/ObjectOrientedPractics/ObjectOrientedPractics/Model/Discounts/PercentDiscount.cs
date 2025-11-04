using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Класс, представляющий процентную скидку для определённой категории товаров.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Текущий процент скидки.
        /// </summary>
		private int _percent;
        /// <summary>
        /// Возвращает текущий процент скидки (от 1% до 10%).
        /// </summary>
		public int Percent
		{
			get { return _percent; }
			private set 
			{
                if (value < 1)
                {
                    throw new ArgumentException("Значение должно быть положительное");
                }
                if (value > 10)
                {
                    throw new ArgumentException("Значение не должно быть больше 10");
                }
                _percent = value; 
			}
		}

        /// <summary>
        /// Категория товаров.
        /// </summary>
		private Category _category;
        /// <summary>
        /// Возвращает и задаёт категорию товаров, на которую распространяется скидка.
        /// </summary>
		public Category Category
		{
			get { return _category; }
			set { _category = value; }
		}

        /// <summary>
        /// Общая сумма покупок по категории.
        /// </summary>
		private double _currentAmount;
        /// <summary>
        /// Возвращает и задаёт общую сумму покупок по данной категории товаров.
        /// Используется для увеличения процента скидки.
        /// </summary>
		public double CurrentAmount
		{
			get { return _currentAmount; }
			set { _currentAmount = value; }
		}

        /// <summary>
        /// Возвращает информацию о скидке в виде строки:
        /// "Процентная – "{Категория}" - {Процент}%".
        /// </summary>
        public string Info
        {
            get { return $"Процентная – \"{Category}\" - {Percent}%"; }
        }

        /// <summary>
        /// Рассчитывает возможную сумму скидки для списка товаров.
        /// Скидка применяется только к товарам выбранной категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки в рублях.</returns>
        public double Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0)
            {
                return 0.0;
            }

            double total = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    total += item.Cost;
                }
            }

            int percent = (int)Math.Floor(CurrentAmount / 1000) + 1;
            if (percent > 10) percent = 10;

            return total * percent / 100;
        }

        /// <summary>
        /// Применяет скидку к товарам (логика аналогична Calculate),
        /// возвращает размер применённой скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер применённой скидки в рублях.</returns>
        public double Apply(List<Item> items)
        {
            // Применяем текущую скидку
            double discount = Calculate(items);

            // Обновляем накопление после применения
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == Category)
                {
                    CurrentAmount += items[i].Cost;
                }
            }

            // Обновляем процент
            int newPercent = (int)Math.Floor(CurrentAmount / 1000) + 1;
            if (newPercent > 10) newPercent = 10;
            Percent = newPercent;

            return discount;
        }

        /// <summary>
        /// Обновляет данные скидки после совершения покупки.
        /// Добавляет стоимость купленных товаров в накопленную сумму
        /// и при необходимости увеличивает процент скидки.
        /// </summary>
        /// <param name="items">Список купленных товаров.</param>
        public void Update(List<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    CurrentAmount += item.Cost;
                }
            }

            // Повышаем процент скидки при накоплении
            int newPercent = (int)Math.Floor(CurrentAmount / 1000) + 1;
            if (newPercent > 10){ newPercent = 10; }
            Percent = newPercent;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория для товара.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
            CurrentAmount = 0;
            Percent = 1;
        }
    }
}
