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

namespace Lab3.View
{
    /// <summary>
    /// Небольшое приложение с прямоугольниками.
    /// </summary>
    public partial class RectanglesCollisionControl: UserControl
    {
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Лист с прямоугольниками.
        /// </summary>
        private List<Rectangles> _rectangles = new List<Rectangles>();
        /// <summary>
        /// Прямоугольник, выбранный на данный момент.
        /// </summary>
        private Rectangles _currentRectangle;
        private void AddRectangleButton_Click_1(object sender, EventArgs e)
        {
            //генерация значений для Rectangles и добавление в ListBox
            _currentRectangle = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
            _rectangles.Add(_currentRectangle);
            RectanglesBoxPaint.Items.Add($"{_currentRectangle.ID - 5}: (X= {_currentRectangle.Center.X}; Y= {_currentRectangle.Center.Y}; W= {_currentRectangle.Width}; H= {_currentRectangle.Length})");

            // Создание панели для отображения прямоугольника
            Panel panel = new Panel();
            panel.Location = new Point(_currentRectangle.Center.X - (int)(_currentRectangle.Width / 2), _currentRectangle.Center.Y - (int)(_currentRectangle.Length / 2));
            panel.Size = new Size((int)_currentRectangle.Width, (int)_currentRectangle.Length);
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);

            // Добавление на канву и в список
            CanvasPanel.Controls.Add(panel);
            _rectanglePanels.Add(panel);

            //Проверка на коллизию
            FindCollisions();
        }
        /// <summary>
        /// Значение для отключения события при true.
        /// </summary>
        private bool _suppressEvents = false;
        private void RectanglesBoxPaint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressEvents) return; //Выход при true

            ErrorLabel.Text = "";
            IDBoxPaint.Clear();
            XBoxPaint.Clear();
            YBoxPaint.Clear();
            WidthBoxPaint.Clear();
            HeightBoxPaint.Clear();
            IDBoxPaint.ReadOnly = false;
            
            //Присваивание значений в текстбоксы для выбранного элемента
            int rectangleID = RectanglesBoxPaint.SelectedIndex;
            if (rectangleID != -1)
            {
                _currentRectangle = _rectangles[rectangleID];

                IDBoxPaint.Text = $"{_rectangles[rectangleID].ID - 5}";
                XBoxPaint.Text = _rectangles[rectangleID].Center.X.ToString();
                YBoxPaint.Text = _rectangles[rectangleID].Center.Y.ToString();
                WidthBoxPaint.Text = _rectangles[rectangleID].Width.ToString();
                HeightBoxPaint.Text = _rectangles[rectangleID].Length.ToString();
                IDBoxPaint.ReadOnly = true;
            }
        }
        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesBoxPaint.SelectedIndex;
            RectanglesBoxPaint.ClearSelected();

            // на случай если удаляемый элемент не выбран
            if (selectedIndex != -1)
            {
                RectanglesBoxPaint.Items.RemoveAt(selectedIndex);
                _rectangles.RemoveAt(selectedIndex);
            }
            else
            {
                ErrorLabel.Text = "Выберите элемент";
            }

            //удаление с панели
            if (selectedIndex != -1)
            {
                CanvasPanel.Controls.RemoveAt(selectedIndex);
                _rectanglePanels.RemoveAt(selectedIndex);
            }

            //Проверка на коллизию
            FindCollisions();
        }

        private void XBoxPaint_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            if (XBoxPaint.Text != "")
            {
                try
                {
                    if (_currentRectangle != null)
                    {
                        _currentRectangle.Center.X = Int32.Parse(XBoxPaint.Text);
                        // Отключаем событие, чтобы не было зациклинности
                        _suppressEvents = true;
                        RectanglesBoxPaint.Items[RectanglesBoxPaint.SelectedIndex] = ($"{_currentRectangle.ID - 5}: (X= {_currentRectangle.Center.X}; Y= {_currentRectangle.Center.Y}; W= {_currentRectangle.Width}; H= {_currentRectangle.Length})");
                        // Включаем обратно
                        _suppressEvents = false;

                        //изменение размеров панели
                        _rectanglePanels[RectanglesBoxPaint.SelectedIndex].Location = new Point(_currentRectangle.Center.X - (int)(_currentRectangle.Width / 2), _currentRectangle.Center.Y - (int)(_currentRectangle.Length / 2));
                        FindCollisions();
                    }
                }
                catch (Exception)
                {
                    if (XBoxPaint.Text != "")
                    {
                        ErrorLabel.Text = "Неверное значение";
                    }
                }
            }
        }

        private void YBoxPaint_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            if (YBoxPaint.Text != "")
            {
                try
                {
                    if (_currentRectangle != null)
                    {
                        _currentRectangle.Center.Y = Int32.Parse(YBoxPaint.Text);
                        // Отключаем событие, чтобы не было зациклинности
                        _suppressEvents = true;
                        RectanglesBoxPaint.Items[RectanglesBoxPaint.SelectedIndex] = ($"{_currentRectangle.ID - 5}: (X= {_currentRectangle.Center.X}; Y= {_currentRectangle.Center.Y}; W= {_currentRectangle.Width}; H= {_currentRectangle.Length})");
                        // Включаем обратно
                        _suppressEvents = false;

                        //изменение размеров панели
                        _rectanglePanels[RectanglesBoxPaint.SelectedIndex].Location = new Point(_currentRectangle.Center.X - (int)(_currentRectangle.Width / 2), _currentRectangle.Center.Y - (int)(_currentRectangle.Length / 2));
                        FindCollisions();
                    }
                }
                catch (Exception)
                {
                    if (YBoxPaint.Text != "")
                    {
                        ErrorLabel.Text = "Неверное значение";
                    }
                }
            }
        }

        private void WidthBoxPaint_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            if (WidthBoxPaint.Text != "")
            {
                try
                {
                    if (_currentRectangle != null)
                    {
                        _currentRectangle.Width = Int32.Parse(WidthBoxPaint.Text);
                        // Отключаем событие, чтобы не было зациклинности
                        _suppressEvents = true;
                        RectanglesBoxPaint.Items[RectanglesBoxPaint.SelectedIndex] = ($"{_currentRectangle.ID - 5}: (X= {_currentRectangle.Center.X}; Y= {_currentRectangle.Center.Y}; W= {_currentRectangle.Width}; H= {_currentRectangle.Length})");
                        // Включаем обратно
                        _suppressEvents = false;

                        //изменение размеров панели
                        _rectanglePanels[RectanglesBoxPaint.SelectedIndex].Size = new Size((int)_currentRectangle.Width, (int)_currentRectangle.Length);
                        FindCollisions();
                    }
                }
                catch (Exception)
                {
                    if (WidthBoxPaint.Text != "")
                    {
                        ErrorLabel.Text = "Неверное значение";
                    }
                }
            }
        }

        private void HeightBoxPaint_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            if (HeightBoxPaint.Text != "")
            {
                try
                {
                    if (_currentRectangle != null)
                    {
                        _currentRectangle.Length = Int32.Parse(HeightBoxPaint.Text);
                        // Отключаем событие, чтобы не было зациклинности
                        _suppressEvents = true  ;
                        RectanglesBoxPaint.Items[RectanglesBoxPaint.SelectedIndex] = ($"{_currentRectangle.ID - 5}: (X= {_currentRectangle.Center.X}; Y= {_currentRectangle.Center.Y}; W= {_currentRectangle.Width}; H= {_currentRectangle.Length})");
                        // Включаем обратно
                        _suppressEvents = false;

                        //изменение размеров панели
                        _rectanglePanels[RectanglesBoxPaint.SelectedIndex].Size = new Size((int)_currentRectangle.Width, (int)_currentRectangle.Length);
                        FindCollisions();
                    }
                }
                catch (Exception)
                {
                    if (HeightBoxPaint.Text != "")
                    {
                        ErrorLabel.Text = "Неверное значение";
                    }
                }
            }
        }
        /// <summary>
        /// Лист для прямоугольников, отображаемых в панели.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();
        /// <summary>
        /// Проверяет два прямоугольника на соприказновение.
        /// </summary>
        private void FindCollisions()
        {
            // перекрас всех в зелёный
            foreach (Panel i in _rectanglePanels)
            {
                i.BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            // проверка на колизию
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = i + 1; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && _rectangles[i] != _rectangles[j])
                    {
                        //Если соприкасаются, то перекрас в красный
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }

                }
            }
        }
    }
}
