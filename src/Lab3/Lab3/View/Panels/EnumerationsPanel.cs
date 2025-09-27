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
    /// Панель для показа перечислений.
    /// </summary>
    public partial class EnumerationsPanel: UserControl
    {
        /// <summary>
        /// Айди для таблицы EnumsList.
        /// </summary>
        public int EnumID;
        /// <summary>
        /// Айди для таблицы ValueList.
        /// </summary>
        public int ValueID;
        public EnumerationsPanel()
        {
            InitializeComponent();
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e) //Срабатывает когда выбирается из первого списка
        {
            ValueList.Items.Clear();
            EnumID = EnumsList.SelectedIndex; //Сохраняет индекс выбранного перечисления
            string[] enums_values = { };
            switch (EnumID) //Захватываются значения выбранного перечисления
            {
                case 0:
                    enums_values = Enum.GetNames(typeof(Model.Enums.Color));
                    break;
                case 1:
                    enums_values = Enum.GetNames(typeof(Model.Enums.Genre));
                    break;
                case 2:
                    enums_values = Enum.GetNames(typeof(Model.Enums.Season));
                    break;
                case 3:
                    enums_values = Enum.GetNames(typeof(Model.Enums.PhoneManufactures));
                    break;
                case 4:
                    enums_values = Enum.GetNames(typeof(Model.Enums.EducationForm));
                    break;
                case 5:
                    enums_values = Enum.GetNames(typeof(Model.Enums.Weekday));
                    break;

            }
            ValueList.Items.AddRange(enums_values); //Добавляет в ValueList значения для выбранного энама
        }
        private void ValueList_SelectedIndexChanged(object sender, EventArgs e) //Срабатывает когда выбирается из второго списка
        {
            indexValue.Clear();
            ValueID = ValueList.SelectedIndex;
            string result = ValueID.ToString();
            indexValue.AppendText(result); //Добавляет в indexValue индекс значения для выбранного энама
        }
    }
    
}
