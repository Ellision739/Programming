using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
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
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Валидатор для проверки свойств товара.
        /// </summary>
        private readonly ValueValidator validator = new ValueValidator();

        /// <summary>
        /// Срабатывает при изменении наименования товара.
        /// </summary>
        public event EventHandler NameChanged;
        /// <summary>
        /// Срабатывает при изменении цены товара.
        /// </summary>
        public event EventHandler CostChanged;
        /// <summary>
        /// Срабатывает при изменении описания товара.
        /// </summary>
        public event EventHandler InfoChanged;

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
                if (value != _name)
                {
                    validator.AssertStringOnLength(value, 200, "Name");
                    _name = value;
                    NameChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (value != _info)
                {
                    validator.AssertStringOnLength(value, 1000, "Info");
                    _info = value;
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (value != _cost)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, EventArgs.Empty);
                }
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
        public Item(string name, string info, double cost, string category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            counter++;
            _id = counter;
            Category = (Category)Enum.Parse(typeof(Category), category);
        }

        /// <inheritdoc />
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category.ToString());
        }

        /// <inheritdoc />
        public bool Equals(Item other)
        {
            if (other == null) return false;
            return this.Name == other.Name && this.Info == other.Info && this.Cost == other.Cost && this.Category == other.Category;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return Equals(obj as Item);
        }

        /// <inheritdoc />
        public int CompareTo(Item other)
        {
            if (other == null) return 1;

            return Cost.CompareTo(other.Cost);
        }
    }
}