using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    /// <summary>
    /// Хранит информацию о прямоугольнике.
    /// </summary>
    class Rectangles
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;
        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Возвращает и задаёт длину прямоугольника. Должно быть вещественное положительное число.
        /// </summary>
        public double Length
        {
            get { return _length;}
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Должно быть вещественное положительное число.
        /// </summary>
        public double Width
        {
            get { return _width;}
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Возвращает и задаёт центр прямоугольника. Состоит из класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get; set; }
        /// <summary>
        /// Колличество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;
        /// <summary>
        /// Возвращает колличество всех прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
            private set { _allRectanglesCount = value; }
        }
        /// <summary>
        /// Уникальное идентификатор для прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangles"/>.
        /// </summary>
        /// <param name="length">Длина. Должно быть вещественное положительное число.</param>
        /// <param name="width">Ширина. Должно быть вещественное положительное число.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="x">Точка Х. Должно быть целое положительное число.</param>
        /// <param name="y">Точка У. Должно быть целое положительное число.</param>
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
