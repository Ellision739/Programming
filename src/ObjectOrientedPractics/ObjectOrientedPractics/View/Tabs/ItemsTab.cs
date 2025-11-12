using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Servies;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
            ItemsListBox.DisplayMember = "Name";
            SortComboBox.SelectedIndex = 0;
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
        /// Срабатывает при добавлении/удалении/редактировании товара.
        /// </summary>
        public event EventHandler ItemsChanged;

        /// <summary>
        /// Список с товарами.
        /// </summary>
        private List<Item> _items = new List<Item>();
        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new List<Item>();

                // Сразу обновляем ListBox, чтобы всё было синхронно
                ItemsListBox.Items.Clear();
                foreach (var item in _items)
                {
                    ItemsListBox.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Отсортированный список.
        /// </summary>
        public List<Item> FiltredItems { get; set; }

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
                if (elementsItem.Length < 4) return;
                _currentItem = new Item(elementsItem[0], elementsItem[1], Int32.Parse(elementsItem[2]), elementsItem[3]);

                //Добавление нового товара туда, куда нужно
                int index = 0;
                string newItem = $"{_currentItem.Name}";
                var comparer = StringComparer.Create(new CultureInfo("ru-RU"), false);
                while (index < _items.Count && comparer.Compare(_items[index].Name, _currentItem.Name) < 0)
                {
                    index++;
                }
                ItemsListBox.Items.Insert(index, _currentItem); // Добавляем сам объект
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
                    if (elementsItems.Length < 4) continue;
                    _currentItem = new Item(elementsItems[0], elementsItems[1], Int32.Parse(elementsItems[2]), elementsItems[3]);
                    _items.Add(_currentItem);

                }
            }
            //Сортировка после загрузки
            //var comparer = StringComparer.Create(new CultureInfo("ru-RU"), true);
            //_items.Sort((x, y) => comparer.Compare(x.Name, y.Name));

            //ItemsListBox.Items.Clear();
            //foreach (var it in _items)
            //{
            //    ItemsListBox.Items.Add(it);
            //}
            UpdateItemsListBox();
        }
        public void AddButton_Click(object sender, EventArgs e)
        {
            AddItem();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressEvents) return; //При отключенном событии выходит

            _currentItem = (Item)ItemsListBox.SelectedItem;
            if (_currentItem == null)
            {
                IdTextBox.Clear();
                CostTextBox.Clear();
                NameTextBox.Clear();
                DescriptionTextBox.Clear();
                CategoryComboBox.SelectedIndex = -1;
                CategoryComboBox.Text = "";
                InfoLabel.Text = "";
                return;
            }

            // Присваивание данных в текстбоксы

            _suppressEvents = true;

            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            DescriptionTextBox.Text = _currentItem.Info;
            CategoryComboBox.Text = _currentItem.Category.ToString();

            _suppressEvents = false;

        }
        public void RemoveButton_Click(object sender, EventArgs e)
        {
            string filePathList = "C:/Users/User/Desktop/Programming/src/ObjectOrientedPractics/ObjectOrientedPractics/Servies/ItemsList.txt";
            //List<string> linesList = File.ReadAllLines(filePathList).ToList();

            Item itemToRemove = (Item)ItemsListBox.SelectedItem; // Получаем объект

            if (itemToRemove == null)
            {
                InfoLabel.Text = "Выберите товар для удаления";
            }
            else
            {
                // Удаляем объект из _items (главный список)
                _items.Remove(itemToRemove);

                // Удаляем объект из ListBox
                ItemsListBox.Items.Remove(itemToRemove);

                List<string> linesList = new List<string>();
                foreach (Item i in _items)
                {
                    linesList.Add($"{i.Name}|{i.Info}|{i.Cost}|{i.Category}");
                }
                File.WriteAllLines(filePathList, linesList);

                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                    _currentItem.Cost = Int32.Parse(CostTextBox.Text);
                    ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                    InfoLabel.Text = "";

                    // Обновляем имя у текущего товара
                    _currentItem.Name = NameTextBox.Text;

                    ItemsChanged?.Invoke(this, EventArgs.Empty);

                    // Сохраняем выбранный элемент перед обновлением списка
                    var selectedItem = _currentItem;
                    _suppressEvents = true;
                    UpdateItemsListBox();

                    // Возвращаем выделение на обновленный элемент
                    ItemsListBox.SelectedIndex = FiltredItems.IndexOf(selectedItem);
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
                    _currentItem.Info = DescriptionTextBox.Text;

                    ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                _currentItem.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateItemsListBox();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItemsListBox();
        }

        public void UpdateItemsListBox()
        {
            List<Item> listToShow;

            // Фильтрация
            string filterText = FindTextBox.Text;

            if (string.IsNullOrEmpty(filterText))
            {
                // Если фильтра нет, берем полный список
                listToShow = new List<Item>(Items);
            }
            else
            {
                // Если фильтр есть, применяем его к полному списку Items
                listToShow = DataTools.Filter(Items, DataTools.TextFilter, filterText);
            }

            // Сортировка
            if (SortComboBox.SelectedIndex == 0)
            {
                listToShow = DataTools.Sort(listToShow, DataTools.SortForNames);
            }
            else if (SortComboBox.SelectedIndex == 1)
            {
                listToShow = DataTools.Sort(listToShow, DataTools.SortForCostAscending);
            }
            else if (SortComboBox.SelectedIndex == 2)
            {
                listToShow = DataTools.Sort(listToShow, DataTools.SortForCostDescending);
            }

            // Обновление ListBox
            _suppressEvents = true;
            ItemsListBox.Items.Clear();

            foreach (var item in listToShow)
            {
                ItemsListBox.Items.Add(item);
            }
            _suppressEvents = false;

            FiltredItems = listToShow;
        }
    }
}