using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using static Lab8.Song;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Lab8
{
    /// <summary>
    /// Приложение с песнями.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadSaveSongs();
            AddPhotoForButtons();
            if (_songList.Count == 0)
            {
                AddSong();
                AddSong();
                AddSong();
                AddSong();
                AddSong();
            }
        }
        /// <summary>
        /// Список с песнями.
        /// </summary>
        private List<Song> _songList = new List<Song>();
        /// <summary>
        /// Песня, выбранная на данный момент.
        /// </summary>
        private Song _currentSong;
        /// <summary>
        /// Значение для отключения события при true.
        /// </summary>
        private bool _suppressEvents = false;
        /// <summary>
        /// Добавляет песню в список, на ListBox и в файл SongsList. Берёт песни из файла ArchiveSongs.
        /// </summary>
        public void AddSong()
        {
            string filePathArchive = "C:/Users/User/Desktop/Programming/Lab8/Lab8/ArchiveSongs.txt";
            string filePathList = "C:/Users/User/Desktop/Programming/Lab8/Lab8/SongsList.txt";

            // Считываем все строки
            List<string> linesArchive = File.ReadAllLines(filePathArchive).ToList();

            // Проверяем, что файл не пустой
            if (linesArchive.Count > 0)
            {
                string song = linesArchive[0];
                linesArchive.RemoveAt(0); // Удаляем первую строку
                File.WriteAllLines(filePathArchive, linesArchive); // Перезаписываем файл

                //Добавление в другой файл и записывание в список
                File.AppendAllText(filePathList, song + "\n");

                //Сортировка в файле
                List<string> linesSongsList = File.ReadAllLines(filePathList).ToList();
                var sortedList = linesSongsList.OrderBy(word => word, StringComparer.Create(new CultureInfo("ru-RU"), false)).ToList();
                File.WriteAllLines(filePathList, sortedList); // Перезаписываем файл

                //Разделение строки из файла и создание сейчашней песни
                string[] elementsSong = song.Split('|');
                _currentSong = new Song(elementsSong[1], elementsSong[0], Int32.Parse(elementsSong[2]), elementsSong[3]);

                //Добавление новой песни туда, куда нужно
                int index = 0;
                string newItem = $"{_currentSong.ArtistName} — {_currentSong.SongTitle}";
                var comparer = StringComparer.Create(new CultureInfo("ru-RU"), false);
                while (index < SongsBox.Items.Count && comparer.Compare(SongsBox.Items[index].ToString(), newItem) < 0)
                {
                    index++;
                }
                SongsBox.Items.Insert(index, newItem); //Добавление в Коробку
                _songList.Insert(index, _currentSong); //Добавление в Песни

                SongsBox.SelectedIndex = index;
            }
            else
            {
                InfoLabel.Text = "Песни закончились(((";
            }
        }
        /// <summary>
        /// Считывает песни с файла SongsList и отображает в ListBox в форме.
        /// </summary>
        public void ReadSaveSongs()
        {
            string filePathList = "C:/Users/User/Desktop/Programming/Lab8/Lab8/SongsList.txt";
            List<string> linesList = File.ReadAllLines(filePathList).ToList();
            if (linesList.Count != 0)
            {
                foreach (string i in linesList)//проходится по каждой строчке файла
                {
                    //Разделение и добавление в _songList
                    string[] elementsSong = i.Split('|');
                    _currentSong = new Song(elementsSong[1], elementsSong[0], Int32.Parse(elementsSong[2]), elementsSong[3]);
                    _songList.Add(_currentSong);

                    SongsBox.Items.Add($"{_currentSong.ArtistName} — {_currentSong.SongTitle}"); //Добавление в Коробку
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSong();
        }

        private void SongsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressEvents) return; //При отключенном событии выходит

            //Очистка перед изменением
            SongTitleTextBox.Clear();
            ArtistNameTextBox.Clear();
            DurationTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
            GenreComboBox.Text = "";
            InfoLabel.Text = "";
            SaveLabel.Text = "";

            //Присваивание данных в текстбоксы
            int songID = SongsBox.SelectedIndex;
            if (songID != -1)
            {
                _currentSong = _songList[songID];
                SongTitleTextBox.Text = _songList[songID].SongTitle;
                ArtistNameTextBox.Text = _songList[songID].ArtistName;
                DurationTextBox.Text = _songList[songID].Duration.ToString();
                GenreComboBox.Text = _songList[songID].MusicGenre.ToString();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string filePathList = "C:/Users/User/Desktop/Programming/Lab8/Lab8/SongsList.txt";
            List<string> linesList = File.ReadAllLines(filePathList).ToList();

            int songID = SongsBox.SelectedIndex;
            if (songID == -1)
            {
                InfoLabel.Text = "Выберите песню для удаления";
            }
            else
            {
                //Извлечение песни из файла, _songList и SongBox (ListBox)
                linesList.RemoveAt(songID);
                File.WriteAllLines(filePathList, linesList); // Перезаписываем файл
                _songList.RemoveAt(songID);
                SongsBox.Items.RemoveAt(songID);
            }
        }

        private void EditingButton_Click(object sender, EventArgs e)
        {
            string filePathList = "C:/Users/User/Desktop/Programming/Lab8/Lab8/SongsList.txt";
            List<string> linesList = new List<string>();

            //Перезаписывание всех песен в файл
            foreach (Song i in _songList)
            {
                linesList.Add($"{i.ArtistName}|{i.SongTitle}|{i.Duration}|{i.MusicGenre}");
            }
            File.WriteAllLines(filePathList, linesList);
            if (InfoLabel.Text != "" && InfoLabel.Text != "Выберите песню для удаления")
            {
                SaveLabel.Text = "Невозможно сохранить, неверное значение";
            }
            else
            {
                SaveLabel.Text = "Сохранено в файл!";
            }
        }

        private void SongTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentSong != null && SongTitleTextBox.Text != "")
            {
                try
                {
                    //переписывание значения в _songList
                    InfoLabel.Text = "";
                    _songList[SongsBox.SelectedIndex].SongTitle = SongTitleTextBox.Text;
                    //сохранение в боксе
                    _suppressEvents = true;
                    SongsBox.Items[SongsBox.SelectedIndex] = $"{_currentSong.ArtistName} — {_currentSong.SongTitle}";
                    _suppressEvents = false;
                }
                catch (Exception)
                {
                    InfoLabel.Text = "Неверное значение: Название песни не должно превышать 50 символов";
                }
            }
        }

        private void ArtistNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentSong != null && ArtistNameTextBox.Text != "")
            {
                try
                {
                    //переписывание значения в _songList
                    InfoLabel.Text = "";
                    _songList[SongsBox.SelectedIndex].ArtistName = ArtistNameTextBox.Text;
                    //сохранение в боксе
                    InfoLabel.Text = "";

                    // Обновляем имя исполнителя у текущей песни
                    _currentSong.ArtistName = ArtistNameTextBox.Text;

                    // Сохраняем текущую песню (чтобы потом выделить)
                    var selected = _currentSong;

                    // Сортируем _songList
                    _songList = _songList.OrderBy(s => s.ArtistName, StringComparer.Create(new System.Globalization.CultureInfo("ru-RU"), true)).ToList();

                    // Перестраиваем SongsBox
                    _suppressEvents = true;
                    SongsBox.Items.Clear();

                    foreach (var song in _songList)
                    {
                        SongsBox.Items.Add($"{song.ArtistName} — {song.SongTitle}");
                    }

                    // Назначаем текущую песню снова (ищем по совпадению)
                    int newIndex = _songList.IndexOf(selected);
                    SongsBox.SelectedIndex = newIndex;

                    _suppressEvents = false;
                }
                catch (Exception)
                {
                    InfoLabel.Text = "Неверное значение: Название исполнителя не должно превышать 50 символов";
                }
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentSong != null && DurationTextBox.Text != "")
            {
                try
                {
                    InfoLabel.Text = "";
                    //переписывание значения в _songList
                    _songList[SongsBox.SelectedIndex].Duration = Int32.Parse(DurationTextBox.Text);
                }
                catch (Exception)
                {
                    InfoLabel.Text = "Неверное значение: Продолжительность должна быть положительным числом, не превышающим 7200";
                }
            }
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentSong != null && GenreComboBox.Text != "")
            {
                try
                {
                    InfoLabel.Text = "";
                    //переписывание значения в _songList
                    _songList[SongsBox.SelectedIndex].MusicGenre = (Genre)Enum.Parse(typeof(Genre), GenreComboBox.Text);
                }
                catch (Exception)
                {
                    InfoLabel.Text = "Неверное значение";
                }
            }
        }
        /// <summary>
        /// Добавляет отображение фото для кнопок.
        /// </summary>
        private void AddPhotoForButtons()
        {
            //Для кнопки добавления
            var originalImage = Image.FromFile("C:/Users/User/Desktop/Programming/Lab8/Lab8/ios-add-circle-outline-logo-icon-png-svg.png");
            var resizedImage = new Bitmap(originalImage, new Size(50, 50));
            AddButton.BackgroundImage = resizedImage;
            AddButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddButton.Size = new Size(50, 50);

            //Для кнопки сохранения
            originalImage = Image.FromFile("C:/Users/User/Desktop/Programming/Lab8/Lab8/Save-Button-PNG-File-Download-Free.png");
            resizedImage = new Bitmap(originalImage, new Size(50, 50));
            SaveButton.BackgroundImage = resizedImage;
            SaveButton.BackgroundImageLayout = ImageLayout.Stretch;
            SaveButton.Size = new Size(50, 50);

            //Для кнопки удаления
            originalImage = Image.FromFile("C:/Users/User/Desktop/Programming/Lab8/Lab8/X-circle_(CoreUI_Icons_v1.0.0).svg.png");
            resizedImage = new Bitmap(originalImage, new Size(50, 50));
            DeleteButton.BackgroundImage = resizedImage;
            DeleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteButton.Size = new Size(50, 50);
        }
    }
}
