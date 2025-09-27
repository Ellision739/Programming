using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Model.Geometry;
using Lab3.Model;

namespace Lab3.View.Panels
{
    /// <summary>
    /// Панель для отображения полей сгенерированных прямоугольников с возможностью редактирования.
    /// </summary>
    public partial class RectanglesPanel : UserControl
    {
        public RectanglesPanel()
        {
            InitializeComponent();
            InitializeRectangles();
        }
        /// <summary>
        /// Айди для прямоугольника.
        /// </summary>
        public int rectangleID;

        //Генерация значений для прямоугольников через отдельный класс
        private Rectangles[] _rectangle = new Rectangles[5];
        /// <summary>
        /// Генерация значений для пяти прямоугольников.
        /// </summary>
        public void InitializeRectangles()
        {
            _rectangle[0] = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
            _rectangle[1] = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
            _rectangle[2] = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
            _rectangle[3] = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
            _rectangle[4] = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
        }

        private void RectanglesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Вывод значений в текстбоксы
            LengthBox.Clear();
            WidthBox.Clear();
            ColorBox.Clear();
            resultLabel.Text = "";

            rectangleID = RectanglesBox.SelectedIndex;

            //Присваивание значений в текстбоксы через айди
            LengthBox.Text = _rectangle[rectangleID].Length.ToString();
            WidthBox.Text = _rectangle[rectangleID].Width.ToString();
            ColorBox.Text = _rectangle[rectangleID].Color.ToString();
            CenterBox.Text = $"X = {_rectangle[rectangleID].Center.X}; Y = {_rectangle[rectangleID].Center.Y}";
            IDBox.Text = _rectangle[rectangleID].ID.ToString();
        }

        private void rememberButton_Click(object sender, EventArgs e) //Запоминание новых значений при помощи индекса, try catch на случай ошибки аргумента
        {
            try
            {
                //Присваивание новых значений в свойства прямоугольника
                _rectangle[rectangleID].Length = Convert.ToDouble(LengthBox.Text);
                _rectangle[rectangleID].Width = Convert.ToDouble(WidthBox.Text);
                _rectangle[rectangleID].Color = ColorBox.Text;
                resultLabel.Text = "Сохранено";
            }
            catch (Exception)
            {
                resultLabel.Text = "Некорректно введены данные";
                resultLabel.ForeColor = Color.Red;
            }
            resultLabel.ForeColor = Color.Black;
        }

        /// <summary>
        /// Поиск большей длины среди сгенерированных прямоугольников.
        /// </summary>
        /// <param name="widths">Массив ширин прямоугольников.</param>
        /// <returns>Индекс прямоугольника с большей шириной.</returns>
        private int FindRectangleWithWidth(double[] widths)
        {
            double result = widths.Max();
            if (_rectangle[0].Width == result)
            {
                return 0;
            }
            else if (_rectangle[1].Width == result)
            {
                return 1;
            }
            else if (_rectangle[2].Width == result)
            {
                return 2;
            }
            else if (_rectangle[3].Width == result)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        private void findButton_Click(object sender, EventArgs e)
        {
            //создание массива с шириной прямоугольников
            double[] widths = { _rectangle[0].Width, _rectangle[1].Width, _rectangle[2].Width, _rectangle[3].Width, _rectangle[4].Width };
            resultLabel.Text = FindRectangleWithWidth(widths).ToString(); //вывод в текстбокс индекс прямоугольника с большей шириной
        }
    }
}
