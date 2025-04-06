using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    class Ring
    {
        public Point2D Center { get; set; }
        private double _outerRadius;
        private double _innerRadius;

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
        private double _area;

        public double Area
        {
            get { return _area; }
            private set 
            {
                _area = value; 
            }
        }


        public Ring(double outerRadius, double innerRadius, int x, int y)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Area = 3.14 * outerRadius * outerRadius - 3.14 * innerRadius * innerRadius;
            Center = new Point2D(x, y);
        }
    }
}
