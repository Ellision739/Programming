using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
            ReadSaveItems();
            if (_customers.Count == 0)
            {
                AddCustomer();
                AddCustomer();
                AddCustomer();
                AddCustomer();
                AddCustomer();
            }
        }
        /// <summary>
        /// Список с покупателями.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();
        /// <summary>
        /// Покупатель, выбранный на данный момент.
        /// </summary>
        private Customer _currentCustomer;
        /// <summary>
        /// Значение для отключения события при true.
        /// </summary>
        private bool _suppressEvents = false;
        /// <summary>
        /// Добавляет покупателя в список, на ListBox и в файл CustomersList. Берёт песни из файла ArchiveCustomers.
        /// </summary>
        public void AddCustomer()
        {
            string filePathArchive = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/ArchiveCustomers.txt";
            string filePathList = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/CustomersList.txt";

            // Считываем все строки
            List<string> linesArchive = File.ReadAllLines(filePathArchive, Encoding.UTF8).ToList();

            // Проверяем, что файл не пустой
            if (linesArchive.Count > 0)
            {
                string item = linesArchive[0];
                linesArchive.RemoveAt(0); // Удаляем первую строку
                File.WriteAllLines(filePathArchive, linesArchive); // Перезаписываем файл

                //Добавление в другой файл и записывание в список
                File.AppendAllText(filePathList, item + "\n");

                //Сортировка в файле
                List<string> linesSongsList = File.ReadAllLines(filePathList, Encoding.UTF8).ToList();
                var sortedList = linesSongsList.OrderBy(word => word, StringComparer.Create(new CultureInfo("ru-RU"), false)).ToList();
                File.WriteAllLines(filePathList, sortedList); // Перезаписываем файл

                //Разделение строки из файла и создание сейчашней песни
                string[] elementsCustomer = item.Split('|');
                _currentCustomer = new Customer(elementsCustomer[0], elementsCustomer[1]);

                //Добавление нового покупателя туда, куда нужно
                int index = 0;
                string newCustomer = $"{_currentCustomer.Fullname}";
                var comparer = StringComparer.Create(new CultureInfo("ru-RU"), false);
                while (index < CustomersListBox.Items.Count && comparer.Compare(CustomersListBox.Items[index].ToString(), newCustomer) < 0)
                {
                    index++;
                }
                CustomersListBox.Items.Insert(index, newCustomer); //Добавление в Коробку
                _customers.Insert(index, _currentCustomer); //Добавление в Покупатели

                CustomersListBox.SelectedIndex = index;
            }
            else
            {
                InfoCLabel.Text = "Покупатели закончились(((";
            }
        }
        /// <summary>
        /// Считывает покупателей с файла CustomersList и отображает в ListBox в форме.
        /// </summary>
        public void ReadSaveItems()
        {
            string filePathList = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/CustomersList.txt";
            List<string> linesList = File.ReadAllLines(filePathList, Encoding.UTF8).ToList();
            if (linesList.Count != 0)
            {
                foreach (string i in linesList)//проходится по каждой строчке файла
                {
                    //Разделение и добавление в _customers
                    string[] elementsCustomers = i.Split('|');
                    _currentCustomer = new Customer(elementsCustomers[0], elementsCustomers[1]);
                    _customers.Add(_currentCustomer);

                    CustomersListBox.Items.Add($"{_currentCustomer.Fullname}"); //Добавление в Коробку
                }
            }
        }
        public void AddCButton_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressEvents) return; //При отключенном событии выходит

            //Очистка перед изменением
            IdCTextBox.Clear();
            FullnameTextBox.Clear();
            AddressTextBox.Clear();
            InfoCLabel.Text = "";
            //SaveLabel.Text = "";

            //Присваивание данных в текстбоксы
            int itemIndex = CustomersListBox.SelectedIndex;
            if (itemIndex != -1)
            {
                _currentCustomer = _customers[itemIndex];
                IdCTextBox.Text = _customers[itemIndex].Id.ToString();
                AddressTextBox.Text = _customers[itemIndex].Address;
                FullnameTextBox.Text = _customers[itemIndex].Fullname;
            }
        }
        public void RemoveCButton_Click(object sender, EventArgs e)
        {
            string filePathList = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/CustomersList.txt";
            List<string> linesList = File.ReadAllLines(filePathList).ToList();

            int itemIndex = CustomersListBox.SelectedIndex;
            if (itemIndex == -1)
            {
                InfoCLabel.Text = "Выберите песню для удаления";
            }
            else
            {
                //Извлечение покупателя из файла, _customers и CustomersListBox (ListBox)
                linesList.RemoveAt(itemIndex);
                File.WriteAllLines(filePathList, linesList); // Перезаписываем файл
                _customers.RemoveAt(itemIndex);
                CustomersListBox.Items.RemoveAt(itemIndex);
            }
        }

        private void SaveCButton_Click(object sender, EventArgs e)
        {
            string filePathList = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/CustomersList.txt";
            List<string> linesList = new List<string>();

            //Перезаписывание всех покупателей в файл
            foreach (Customer i in _customers)
            {
                linesList.Add($"{i.Fullname}|{i.Address}");
            }
            File.WriteAllLines(filePathList, linesList);
            if (InfoCLabel.Text != "" && InfoCLabel.Text != "Выберите покупателя для удаления")
            {
                InfoCLabel.Text = "Невозможно сохранить, неверное значение";
            }
            else
            {
                InfoCLabel.Text = "Сохранено в файл!";
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null && AddressTextBox.Text != "")
            {
                try
                {
                    InfoCLabel.Text = "";
                    //переписывание значения в _customers
                    _customers[CustomersListBox.SelectedIndex].Address = AddressTextBox.Text;
                }
                catch (Exception)
                {
                    InfoCLabel.Text = "Неверное значение: Адрес покупателя не должен превышать 500 символов";
                }
            }
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null && FullnameTextBox.Text != "")
            {
                try
                {
                    //переписывание значения в _customers
                    InfoCLabel.Text = "";
                    _customers[CustomersListBox.SelectedIndex].Fullname = FullnameTextBox.Text;
                    //сохранение в боксе
                    InfoCLabel.Text = "";

                    // Обновляем имя у текущего покупателя
                    _currentCustomer.Fullname = FullnameTextBox.Text;

                    // Сохраняем текущего покупателя (чтобы потом выделить)
                    var selected = _currentCustomer;

                    // Сортируем _customers
                    _customers = _customers.OrderBy(s => s.Fullname, StringComparer.Create(new System.Globalization.CultureInfo("ru-RU"), true)).ToList();

                    // Перестраиваем CustomersListBox
                    _suppressEvents = true;
                    CustomersListBox.Items.Clear();

                    foreach (var customer in _customers)
                    {
                        CustomersListBox.Items.Add($"{customer.Fullname}");
                    }

                    // Назначаем текущего покупателя снова (ищем по совпадению)
                    int newIndex = _customers.IndexOf(selected);
                    CustomersListBox.SelectedIndex = newIndex;

                    _suppressEvents = false;
                }
                catch (Exception)
                {
                    InfoCLabel.Text = "Неверное значение: Полное имя покупателя не должно превышать 200 символов";
                }
            }
        }
    }
}

