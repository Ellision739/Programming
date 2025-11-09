using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Servies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Описывает покупателя с уникальным идентификатором, ФИО и адресом.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Валидатор для проверки свойств покупателя.
        /// </summary>
        private readonly ValueValidator validator = new ValueValidator();

        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Статический счётчик для генерации уникальных идентификаторов покупателей.
        /// </summary>
        private static int counter;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя. 
        /// Длина строки не должна превышать 200 символов.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                validator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает и задаёт адрес покупателя. 
        /// Длина строки не должна превышать 500 символов.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }
        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;
        /// <summary>
        /// Возвращает корзину покупателя класса Cart.
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private List<Order> _orders;
        /// <summary>
        /// Возвращает и задаёт список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Значение приоритета покупателя.
        /// </summary>
        private bool _isPriority;
        /// <summary>
        /// Возвращает и задаёт приоритет покупателя.
        /// </summary>
        public bool IsPriority
        {
            get { return _isPriority; }
            set { _isPriority = value; }
        }

        /// <summary>
        /// Возвращает и задаёт список скидок, доступных покупателю.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя (не более 200 символов).</param>
        /// <param name="address">Адрес покупателя (не более 500 символов).</param>
        public Customer(string fullname, Address address, bool isPriority)
        {
            Fullname = fullname;
            Address = address;
            counter++;
            _id = counter;
            _cart = new Cart();
            _orders = new List<Order>();
            IsPriority = isPriority;
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }
    }
}