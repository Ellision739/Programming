using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Описывает заказ покупателя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Статический счётчик для генерации уникальных идентификаторов.
        /// </summary>
        private static int counter;

        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly DateTime _dateOfCreation;

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime DateOfCreation
        {
            get { return _dateOfCreation; }
        }

        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        private Address _deliveryAddress;

        /// <summary>
        /// Возвращает и задаёт адрес доставки заказа.
        /// </summary>
        public Address DeliveryAddress
        {
            get { return _deliveryAddress; }
            set { _deliveryAddress = value; }
        }

        /// <summary>
        /// Список товаров, входящих в заказ.
        /// </summary>
        private List<Item> _listOfProducts;

        /// <summary>
        /// Возвращает и задаёт список товаров, входящих в заказ.
        /// </summary>
        public List<Item> ListOfProducts
        {
            get { return _listOfProducts; }
            set { _listOfProducts = value; }
        }

        private OrderStatus _status;

        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }


        /// <summary>
        /// Общая стоимость всех товаров в заказе.
        /// </summary>
        private double _totalCost;

        /// <summary>
        /// Возвращает и задаёт общую стоимость всех товаров в заказе.
        /// </summary>
        public double TotalCost
        {
            get
            {
                _totalCost = 0.0;
                if (ListOfProducts != null && ListOfProducts.Count != 0)
                {
                    foreach (var item in ListOfProducts)
                    {
                        _totalCost += item.Cost;
                    }
                }
                return _totalCost;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="items">Список товаров для включения в заказ.</param>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        public Order(List<Item> items, Address address)
        {
            _id = counter++;
            _dateOfCreation = DateTime.Now;
            DeliveryAddress = address;
            Status = OrderStatus.New;
            // Создаем новый список, чтобы изменения в корзине не влияли на заказ
            ListOfProducts = new List<Item>(items);
        }
    }
}