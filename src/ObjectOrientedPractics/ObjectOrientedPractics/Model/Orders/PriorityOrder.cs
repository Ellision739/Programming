using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Описывает приоритетный заказ покупателя.
    /// Наследуется от класса Order.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Поле для желаемой даты доставки.
        /// </summary>
        private DateTime _desiredDeliveryDate;

        /// <summary>
        /// Возвращает и задает желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate
        {
            get { return _desiredDeliveryDate; }
            set { _desiredDeliveryDate = value; }
        }

        /// <summary>
        /// Поле для желаемого времени доставки (диапазон).
        /// </summary>
        private DeliveryTime _desiredDeliveryTime;

        /// <summary>
        /// Возвращает и задает желаемое время доставки.
        /// </summary>
        public DeliveryTime DesiredDeliveryTime
        {
            get { return _desiredDeliveryTime; }
            set { _desiredDeliveryTime = value; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="items">Список товаров для включения в заказ.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки. По умолчанию через неделю.</param>
        /// <param name="desiredDeliveryTime">Желаемое время доставки. По умолчанию с 9:00 - 11:00.</param>
        public PriorityOrder(List<Item> items, Address address)
            : base(items, address)
        {
            DesiredDeliveryDate = DateTime.Now.AddDays(7);
            DesiredDeliveryTime = DeliveryTime.Time_9_00_11_00;
        }
    }
}