using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    /// <summary>
    /// Хранит информацию о кольце.
    /// </summary>
    class Ring
    {
        /// <summary>
        /// Возвращает и задаёт центр кольца. Состоит из класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get; set; }
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;
        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Возвращает и задаёт внешний радиус кольца. Должно быть вещественное положительное число, большее, чем внутренний радиус.
        /// </summary>
        public double OuterRadius
        {
            get { return _outerRadius; }
            set 
            { 
                Validator.AssertOnPositiveValue(value);
                if (value < _innerRadius)
                {
                    throw new ArgumentException("Внешний радиус не может быть меньше внутреннего");
                }
                _outerRadius = value; 
            }
        }
        /// <summary>
        /// Возвращает и задаёт внутренний радиус кольца. Должно быть вещественное положительное число, меньшее, чем внешний радиус.
        /// </summary>
        public double InnerRadius
        {
            get { return _innerRadius; }
            set 
            { 
                Validator.AssertOnPositiveValue(value);
                if (value > _outerRadius)
                {
                    throw new ArgumentException("Внутренний радиус не может быть больше внешнего");
                }
                _innerRadius = value; 
            }
        }
        /// <summary>
        /// Площадь кольца.
        /// </summary>
        private double _area;

        /// <summary>
        /// Возвращает и задаёт площадь кольца.
        /// </summary>
        public double Area
        {
            get { return _area; }
            private set 
            {
                _area = value; 
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус. Должно быть вещественное положительное число, большее, чем внутренний радиус.</param>
        /// <param name="innerRadius">Внутренний радиус. Должно быть вещественное положительное число, меньшее, чем внешний радиус.</param>
        /// <param name="x">Точка Х. Должно быть целое положительное число.</param>
        /// <param name="y">Точка У. Должно быть целое положительное число.</param>
        public Ring(double outerRadius, double innerRadius, int x, int y)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Area = 3.14 * outerRadius * outerRadius - 3.14 * innerRadius * innerRadius;
            Center = new Point2D(x, y);
        }
    }
}
