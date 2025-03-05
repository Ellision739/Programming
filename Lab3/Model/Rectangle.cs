using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    class Rectangles
    {
        private double _length;
        private double _width;
        private string _color;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ожидается неотрицательное значение.");
                }
                _length = value;
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ожидается неотрицательное значение.");
                }
                _width = value;
            }
        }
        public string Color { get { return _color; } set { _color = value; } }

        public Rectangles(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
        public Rectangles()
        {
            
        }
    }
}
