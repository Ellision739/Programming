using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.View.Panels
{
    /// <summary>
    /// Отоброжение сообщения в зависимости от выбранного элемента.
    /// </summary>
    public partial class SeasonHandlePanel: UserControl
    {
        public SeasonHandlePanel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Функция для изменения цвета фона у tabPage в главной форме.
        /// </summary>
        /// <param name="newColor">Цвет для tabPage.</param>
        private void BackColorChange(System.Drawing.Color newColor)
        {
            if (Parent is System.Windows.Forms.TabPage tabPage1)
            {
                tabPage1.BackColor = newColor;
            }
        }
        private void GoButton_Click(object sender, EventArgs e) //При нажатии вывести сообщение в зависимости от текста
        {
            try //Для момента когда текста нет
            {
                string selectedState = SeasonsComboBox.SelectedItem.ToString();
                switch (selectedState)
                {
                    case "Summer":
                        ResultSeasonLabel.Text = "Ура! Солнце!";
                        BackColorChange(System.Drawing.Color.White);
                        break;
                    case "Autumn":
                        ResultSeasonLabel.Text = "";
                        BackColorChange(System.Drawing.Color.Orange);
                        break;
                    case "Winter":
                        BackColorChange(System.Drawing.Color.White);
                        ResultSeasonLabel.Text = "Брр! Холодно!";
                        break;
                    case "Spring":
                        ResultSeasonLabel.Text = "";
                        BackColorChange(System.Drawing.Color.Green);
                        break;
                }
            }
            catch (Exception)
            {
                ResultSeasonLabel.Text = "Введите время года";
            }
        }
    }
}
