using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    /// <summary>
    /// Хранит информацию о времени.
    /// </summary>
    class Time
    {
        /// <summary>
        /// Данные о колличестве часов.
        /// </summary>
        private int _hour;
        /// <summary>
        /// Данные о колличестве минут.
        /// </summary>
        private int _minute;
        /// <summary>
        /// Данные о колличестве минут.
        /// </summary>
        private int _second;

        /// <summary>
        /// Возвращает и задаёт колличество часов. Значение должно быть целое число от 0 до 23.
        /// </summary>
        public int Hour
        {
            get { return _hour; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23);
                _hour = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт колличество минут. Значение должно быть целое число от 0 до 59.
        /// </summary>
        public int Minute
        {
            get { return _minute; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59);
                _minute = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт колличество секунд. Значение должно быть целое число от 0 до 59.
        /// </summary>
        public int Second
        {
            get { return _second; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59);
                _second = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hour">Час. Значение должно быть целое число от 0 до 23.</param>
        /// <param name="minute">Минута. Значение должно быть целое число от 0 до 59.</param>
        /// <param name="second">Секунда. Значение должно быть целое число от 0 до 59.</param>
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {
            
        }
    }
}
