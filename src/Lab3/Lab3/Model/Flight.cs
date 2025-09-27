using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    /// <summary>
    /// Хранит информацию о полёте.
    /// </summary>
    class Flight
    {
        /// <summary>
        /// Точка отправления. Не может быть null.
        /// </summary>
        private string _departurePoint;
        /// <summary>
        /// Точка прибытия. Не может быть null.
        /// </summary>
        private string _destination;
        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _flightTimeMin;

        /// <summary>
        /// Возвращает и задаёт точку отправления.
        /// </summary>
        public string DeparturePoint { get { return _departurePoint; } set { _departurePoint = value; } }
        /// <summary>
        /// Возвращает и задаёт точку прибытия.
        /// </summary>
        public string Destination { get { return _destination; } set { _destination = value; } }
        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Должно быть целое положительное число.
        /// </summary>
        public int FlightTimeMin
        {
            get { return _flightTimeMin; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTimeMin = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Точка отправления. Не может быть null.</param>
        /// <param name="destination">Точка прибытия. Не может быть null.</param>
        /// <param name="flightTimeMin">Время полёта в минутах. Должно быть целое положительное число.</param>
        public Flight(string departurePoint, string destination, int flightTimeMin)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeMin = flightTimeMin;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
            
        }
    }
}
