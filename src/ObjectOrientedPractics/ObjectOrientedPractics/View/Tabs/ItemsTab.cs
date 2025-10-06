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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
            ReadSaveItems();
            if (_items.Count == 0)
            {
                AddItem();
                AddItem();
                AddItem();
                AddItem();
                AddItem();
            }
        }
        /// <summary>
        /// Список с товарами.
        /// </summary>
        private List<Item> _items = new List<Item>();
        /// <summary>
        /// Товар, выбранный на данный момент.
        /// </summary>
        private Item _currentItem;
        /// <summary>
        /// Значение для отключения события при true.
        /// </summary>
        private bool _suppressEvents = false;
        /// <summary>
        /// Добавляет товар в список, на ListBox и в файл ItemsList. Берёт песни из файла ArchiveItems.
        /// </summary>
        public void AddItem()
        {
            string filePathArchive = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/ArchiveItems.txt";
            string filePathList = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/ItemsList.txt";

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

                //Разделение строки из файла и создание товара
                string[] elementsItem = item.Split('|');
                _currentItem = new Item(elementsItem[0], elementsItem[1], Int32.Parse(elementsItem[2]), elementsItem[3]);

                //Добавление нового товара туда, куда нужно
                int index = 0;
                string newItem = $"{_currentItem.Name}";
                var comparer = StringComparer.Create(new CultureInfo("ru-RU"), false);
                while (index < ItemsListBox.Items.Count && comparer.Compare(ItemsListBox.Items[index].ToString(), newItem) < 0)
                {
                    index++;
                }
                ItemsListBox.Items.Insert(index, newItem); //Добавление в Коробку
                _items.Insert(index, _currentItem); //Добавление в Товары

                ItemsListBox.SelectedIndex = index;
            }
            else
            {
                InfoLabel.Text = "Товары закончились(((";
            }
        }
        /// <summary>
        /// Считывает товары с файла ItemsList и отображает в ListBox в форме.
        /// </summary>
        public void ReadSaveItems()
        {
            string filePathList = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/ItemsList.txt";
            List<string> linesList = File.ReadAllLines(filePathList, Encoding.UTF8).ToList();
            if (linesList.Count != 0)
            {
                foreach (string i in linesList)//проходится по каждой строчке файла
                {
                    //Разделение и добавление в _items
                    string[] elementsItems = i.Split('|');
                    _currentItem = new Item(elementsItems[0], elementsItems[1], Int32.Parse(elementsItems[2]), elementsItems[3]);
                    _items.Add(_currentItem);

                    ItemsListBox.Items.Add($"{_currentItem.Name}"); //Добавление в Коробку
                }
            }
        }
        public void AddButton_Click(object sender, EventArgs e)
        {
            AddItem();
        }
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressEvents) return; //При отключенном событии выходит

            //Очистка перед изменением
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
            CategoryComboBox.Text = "";
            InfoLabel.Text = "";
            //SaveLabel.Text = "";

            //Присваивание данных в текстбоксы
            int itemIndex = ItemsListBox.SelectedIndex;
            if (itemIndex != -1)
            {
                _currentItem = _items[itemIndex];
                IdTextBox.Text = _items[itemIndex].Id.ToString();
                CostTextBox.Text = _items[itemIndex].Cost.ToString();
                NameTextBox.Text = _items[itemIndex].Name;
                DescriptionTextBox.Text = _items[itemIndex].Info;
                CategoryComboBox.Text = _items[itemIndex].Category.ToString();
            }
        }
        public void RemoveButton_Click(object sender, EventArgs e)
        {
            string filePathList = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/ItemsList.txt";
            List<string> linesList = File.ReadAllLines(filePathList).ToList();

            int itemIndex = ItemsListBox.SelectedIndex;
            if (itemIndex == -1)
            {
                InfoLabel.Text = "Выберите песню для удаления";
            }
            else
            {
                //Извлечение товара из файла, _items и ItemsListBox (ListBox)
                linesList.RemoveAt(itemIndex);
                File.WriteAllLines(filePathList, linesList); // Перезаписываем файл
                _items.RemoveAt(itemIndex);
                ItemsListBox.Items.RemoveAt(itemIndex);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string filePathList = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/ItemsList.txt";
            List<string> linesList = new List<string>();

            //Перезаписывание всех товаров в файл
            foreach (Item i in _items)
            {
                linesList.Add($"{i.Name}|{i.Info}|{i.Cost}|{i.Category}");
            }
            File.WriteAllLines(filePathList, linesList);
            if (InfoLabel.Text != "" && InfoLabel.Text != "Выберите товар для удаления")
            {
                InfoLabel.Text = "Невозможно сохранить, неверное значение";
            }
            else
            {
                InfoLabel.Text = "Сохранено в файл!";
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && CostTextBox.Text != "")
            {
                try
                {
                    InfoLabel.Text = "";
                    //переписывание значения в _items
                    _items[ItemsListBox.SelectedIndex].Cost = Int32.Parse(CostTextBox.Text);
                }
                catch (Exception)
                {
                    InfoLabel.Text = "Неверное значение: Цена должна быть положительным числом, не превышающим 100 000";
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && NameTextBox.Text != "")
            {
                try
                {
                    //переписывание значения в _items
                    InfoLabel.Text = "";
                    _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                    //сохранение в боксе
                    InfoLabel.Text = "";

                    // Обновляем имя у текущего товара
                    _currentItem.Name = NameTextBox.Text;

                    // Сохраняем текущий товар (чтобы потом выделить)
                    var selected = _currentItem;

                    // Сортируем _items
                    _items = _items.OrderBy(s => s.Name, StringComparer.Create(new System.Globalization.CultureInfo("ru-RU"), true)).ToList();

                    // Перестраиваем ItemsListBox
                    _suppressEvents = true;
                    ItemsListBox.Items.Clear();

                    foreach (var item in _items)
                    {
                        ItemsListBox.Items.Add($"{item.Name}");
                    }

                    // Назначаем текущий товар снова (ищем по совпадению)
                    int newIndex = _items.IndexOf(selected);
                    ItemsListBox.SelectedIndex = newIndex;

                    _suppressEvents = false;
                }
                catch (Exception)
                {
                    InfoLabel.Text = "Неверное значение: Название товара не должно превышать 200 символов";
                }
            }
        }
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && DescriptionTextBox.Text != "")
            {
                try
                {
                    InfoLabel.Text = "";
                    //переписывание значения в _items
                    _items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
                }
                catch (Exception)
                {
                    InfoLabel.Text = "Неверное значение: Описание товара не должно превышать 1000 символов";
                }
            }
        }
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && CategoryComboBox.Text != "")
            {
                InfoLabel.Text = "";
                //переписывание значения в _items
                _items[ItemsListBox.SelectedIndex].Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
            }
        }
    }
}
