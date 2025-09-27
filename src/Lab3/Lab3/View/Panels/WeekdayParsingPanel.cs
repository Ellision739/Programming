using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Model.Enums;

namespace Lab3.View.Panels
{
    /// <summary>
    /// Панель для парсинга элемента enum и вывода сообщения.
    /// </summary>
    public partial class WeekdayParsingPanel : UserControl
    {
        public WeekdayParsingPanel()
        {
            InitializeComponent();
        }
        private void ParseButton_Click(object sender, EventArgs e)
        {
            //При нажатии вывести сообщение в зависимости от текста
            if (Enum.TryParse(DayOfWeekParsBox.Text, true, out Weekday day))
            {
                ParsResultLabel.Text = $"Это день недели ({day} = {(int)day})";
            }
            else //Если введено ошибочное значение
            {
                ParsResultLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
