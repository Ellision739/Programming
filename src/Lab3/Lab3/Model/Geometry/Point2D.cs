using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    /// <summary>
    /// Хранит данные для 2д точки.
    /// </summary>
    class Point2D
    {
        /// <summary>
        /// Точка Х.
        /// </summary>
        private int _x;

        /// <summary>
        /// Возвращает и задаёт значение для Х. Должно быть целое положительное число.
        /// </summary>
        public int X
        {
            get { return _x; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value; 
            }
        }
        /// <summary>
        /// Точка У.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задаёт значение для У. Должно быть целое положительное число.
        /// </summary>
        public int Y
        {
            get { return _y; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Точка Х. Должно быть целое положительное число.</param>
        /// <param name="y">Точка У. Должно быть целое положительное число.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
