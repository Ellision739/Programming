using ObjectOrientedPractics.Servies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Описывает товар (предмет) с уникальным идентификатором, 
    /// названием, описанием и стоимостью.
    /// </summary>
    class Item
    {
        /// <summary>
        /// Валидатор для проверки свойств товара.
        /// </summary>
        private readonly ValueValidator validator = new ValueValidator();

        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Статический счётчик для генерации уникальных идентификаторов.
        /// </summary>
        private static int counter;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Возвращает и задаёт название товара.
        /// Длина строки не должна превышать 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                validator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Возвращает и задаёт описание товара.
        /// Длина строки не должна превышать 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                validator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задаёт стоимость товара.
        /// Значение должно быть положительным и не превышать 100000.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value > 100000)
                {
                    throw new ArgumentException("Значение не должно превышать 100000");
                }
                if (value < 0)
                {
                    throw new ArgumentException("Значение должно быть положительное");
                }
                _cost = value;
            }
        }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара (не более 200 символов).</param>
        /// <param name="info">Описание товара (не более 1000 символов).</param>
        /// <param name="cost">Стоимость товара (0–100000).</param>
        /// <param name="category">Категория товаров из перечисления.</param>
        public Item(string name, string info, int cost, string category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            counter++;
            _id = counter;
            Category = (Category)Enum.Parse(typeof(Category), category);
        }
    }
}
