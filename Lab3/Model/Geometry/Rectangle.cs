using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    class Rectangles
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length;}
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }
        public double Width
        {
            get { return _width;}
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }
        public string Color { get; set; }
        public Point2D Center { get; set; }
        private static int _allRectanglesCount;
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
            set { _allRectanglesCount = value; }
        }
        private int _id;

        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public Rectangles(double length, double width, string color, int x, int y)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(x, y);
            AllRectanglesCount += 1;
            ID = AllRectanglesCount;
        }
    }
}
