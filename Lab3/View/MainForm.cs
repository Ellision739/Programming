using Lab3.Model;
using Lab3.Model.Geometry;
using System.Drawing;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeRectangles();
        }
        public int rectangleID;
        //Генерация значений для прямоугольников через отдельный класс
        private Rectangles[] _rectangle = new Rectangles[5];
        //GenerateRectangles rectangleValue1 = new GenerateRectangles();
        //GenerateRectangles rectangleValue2 = new GenerateRectangles();
        //GenerateRectangles rectangleValue3 = new GenerateRectangles();
        //GenerateRectangles rectangleValue4 = new GenerateRectangles();
        //GenerateRectangles rectangleValue5 = new GenerateRectangles();
        public void InitializeRectangles()
        {
            _rectangle[0] = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
            _rectangle[1] = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
            _rectangle[2] = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
            _rectangle[3] = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
            _rectangle[4] = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
        }


        //private Model.Rectangles[] _rectangles = new Model.Rectangles[5];
        //private Model.Rectangles _currentRectangle = new Model.Rectangles();

        private void RectanglesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Вывод значений в текстбоксы
            LengthBox.Clear();
            WidthBox.Clear();
            ColorBox.Clear();
            resultLabel.Text = "";

            rectangleID = RectanglesBox.SelectedIndex;

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

        private int FindRectangleWithWidth(double[] widths) //поиск большей длины
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
        private void findButton_Click(object sender, EventArgs e) //вывод индекса прямоугольника с большей длиной
        {
            double[] widths = { _rectangle[0].Width, _rectangle[1].Width, _rectangle[2].Width, _rectangle[3].Width, _rectangle[4].Width };
            resultLabel.Text = FindRectangleWithWidth(widths).ToString();
        }

        #region Фильмы
        public int movieID;
        //Генерация значений для фильмов
        static Random rand = new Random();
        static string name1 = "CoolFilmYeah";
        static int duration1 = rand.Next(30, 1000);
        static int year1 = rand.Next(1900, 2025);
        static string genre1 = "CoolGenre";
        static double rating1 = Math.Round(8 + (10 - 8) * rand.NextDouble(), 2);

        static string name2 = "BadShit";
        static int duration2 = rand.Next(30, 1000);
        static int year2 = rand.Next(1900, 2025);
        static string genre2 = "BadGenre";
        static double rating2 = Math.Round(0.1 + (2 - 0.1) * rand.NextDouble(), 2);

        static string name3 = "MagicBruh";
        static int duration3 = rand.Next(30, 1000);
        static int year3 = rand.Next(1900, 2025);
        static string genre3 = "Fantasy";
        static double rating3 = Math.Round(1 + (10 - 1) * rand.NextDouble(), 2);

        static string name4 = "DarkAge";
        static int duration4 = rand.Next(30, 1000);
        static int year4 = rand.Next(1900, 2025);
        static string genre4 = "Medieval";
        static double rating4 = Math.Round(0 + (10 - 0) * rand.NextDouble(), 2);

        static string name5 = "HappyTryFriends";
        static int duration5 = rand.Next(30, 1000);
        static int year5 = rand.Next(1900, 2025);
        static string genre5 = "Family";
        static double rating5 = Math.Round(0 + (10 - 0) * rand.NextDouble(), 2);

        Movie movie1 = new Movie(name1, duration1, year1, genre1, rating1);
        Movie movie2 = new Movie(name2, duration2, year2, genre2, rating2);
        Movie movie3 = new Movie(name3, duration3, year3, genre3, rating3);
        Movie movie4 = new Movie(name4, duration4, year4, genre4, rating4);
        Movie movie5 = new Movie(name5, duration5, year5, genre5, rating5);

        private void MoviesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Вывод значений в текстбоксы
            nameBoxMovies.Clear();
            durationBox.Clear();
            yearBox.Clear();
            genreBox.Clear();
            ratingBox.Clear();
            resultLabelMovies.Text = "";

            movieID = MoviesBox.SelectedIndex;
            switch (movieID)
            {
                case 0:
                    nameBoxMovies.AppendText(movie1.Name.ToString());
                    durationBox.AppendText(movie1.DurationMin.ToString());
                    yearBox.AppendText(movie1.Year.ToString());
                    genreBox.AppendText(movie1.Genre.ToString());
                    ratingBox.AppendText(movie1.Rating.ToString());
                    break;
                case 1:
                    nameBoxMovies.AppendText(movie2.Name.ToString());
                    durationBox.AppendText(movie2.DurationMin.ToString());
                    yearBox.AppendText(movie2.Year.ToString());
                    genreBox.AppendText(movie2.Genre.ToString());
                    ratingBox.AppendText(movie2.Rating.ToString());
                    break;
                case 2:
                    nameBoxMovies.AppendText(movie3.Name.ToString());
                    durationBox.AppendText(movie3.DurationMin.ToString());
                    yearBox.AppendText(movie3.Year.ToString());
                    genreBox.AppendText(movie3.Genre.ToString());
                    ratingBox.AppendText(movie3.Rating.ToString());
                    break;
                case 3:
                    nameBoxMovies.AppendText(movie4.Name.ToString());
                    durationBox.AppendText(movie4.DurationMin.ToString());
                    yearBox.AppendText(movie4.Year.ToString());
                    genreBox.AppendText(movie4.Genre.ToString());
                    ratingBox.AppendText(movie4.Rating.ToString());
                    break;
                case 4:
                    nameBoxMovies.AppendText(movie5.Name.ToString());
                    durationBox.AppendText(movie5.DurationMin.ToString());
                    yearBox.AppendText(movie5.Year.ToString());
                    genreBox.AppendText(movie5.Genre.ToString());
                    ratingBox.AppendText(movie5.Rating.ToString());
                    break;
            }

        }

        private void rememberValuesMovie_Click(object sender, EventArgs e)
        {
            try
            {
                switch (movieID)
                {
                    case 0:
                        movie1.Name = nameBoxMovies.Text;
                        movie1.DurationMin = Convert.ToInt32(durationBox.Text);
                        movie1.Year = Convert.ToInt32(yearBox.Text);
                        movie1.Genre = genreBox.Text;
                        movie1.Rating = Convert.ToDouble(ratingBox.Text);
                        break;
                    case 1:
                        movie2.Name = nameBoxMovies.Text;
                        movie2.DurationMin = Convert.ToInt32(durationBox.Text);
                        movie2.Year = Convert.ToInt32(yearBox.Text);
                        movie2.Genre = genreBox.Text;
                        movie2.Rating = Convert.ToDouble(ratingBox.Text);
                        break;
                    case 2:
                        movie3.Name = nameBoxMovies.Text;
                        movie3.DurationMin = Convert.ToInt32(durationBox.Text);
                        movie3.Year = Convert.ToInt32(yearBox.Text);
                        movie3.Genre = genreBox.Text;
                        movie3.Rating = Convert.ToDouble(ratingBox.Text);
                        break;
                    case 3:
                        movie4.Name = nameBoxMovies.Text;
                        movie4.DurationMin = Convert.ToInt32(durationBox.Text);
                        movie4.Year = Convert.ToInt32(yearBox.Text);
                        movie4.Genre = genreBox.Text;
                        movie4.Rating = Convert.ToDouble(ratingBox.Text);
                        break;
                    case 4:
                        movie5.Name = nameBoxMovies.Text;
                        movie5.DurationMin = Convert.ToInt32(durationBox.Text);
                        movie5.Year = Convert.ToInt32(yearBox.Text);
                        movie5.Genre = genreBox.Text;
                        movie5.Rating = Convert.ToDouble(ratingBox.Text);
                        break;
                }
                resultLabelMovies.Text = "Сохранено";
            }
            catch (Exception)
            {
                resultLabelMovies.Text = "Некорректно введены данные";
                resultLabelMovies.ForeColor = Color.Red;
            }
            resultLabelMovies.ForeColor = Color.Black;
        }
        private int FindMovieWithRating(double[] ratings) //поиск большей длины
        {
            double result = ratings.Max();
            if (movie1.Rating == result)
            {
                return 0;
            }
            else if (movie2.Rating == result)
            {
                return 1;
            }
            else if (movie3.Rating == result)
            {
                return 2;
            }
            else if (movie4.Rating == result)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        private void findMovie_Click(object sender, EventArgs e)
        {
            double[] rating = { movie1.Rating, movie2.Rating, movie3.Rating, movie4.Rating, movie5.Rating };
            resultLabelMovies.Text = FindMovieWithRating(rating).ToString();
        }
        #endregion


        private List<Rectangles> _rectangles = new List<Rectangles>();
        private Rectangles _currentRectangle;
        private void AddRectangleButton_Click_1(object sender, EventArgs e)
        {
            _currentRectangle = new Rectangles(GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetLengthOrWidth(), GenerateRectangles.GetColor(), GenerateRectangles.GetXOrY(), GenerateRectangles.GetXOrY());
            _rectangles.Add(_currentRectangle);
            RectanglesBoxPaint.Items.Add($"{_currentRectangle.ID - 5}: (X= {_currentRectangle.Center.X}; Y= {_currentRectangle.Center.Y}; W= {_currentRectangle.Width}; H= {_currentRectangle.Length})");
        }
        private void RectanglesBoxPaint_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            IDBoxPaint.Clear();
            XBoxPaint.Clear();
            YBoxPaint.Clear();
            WidthBoxPaint.Clear();
            HeightBoxPaint.Clear();

            int rectangleID = RectanglesBoxPaint.SelectedIndex;
            if (rectangleID != -1)
            {
                _currentRectangle = _rectangles[rectangleID];
            }

            IDBoxPaint.Text = $"{_rectangles[rectangleID].ID - 5}";
            XBoxPaint.Text = _rectangles[rectangleID].Center.X.ToString();
            YBoxPaint.Text = _rectangles[rectangleID].Center.Y.ToString();
            WidthBoxPaint.Text = _rectangles[rectangleID].Width.ToString();
            HeightBoxPaint.Text = _rectangles[rectangleID].Length.ToString();
        }
        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesBoxPaint.SelectedIndex;
            RectanglesBoxPaint.ClearSelected();

            if (selectedIndex != -1)
            {
                RectanglesBoxPaint.Items.RemoveAt(selectedIndex);
                _rectangles.RemoveAt(selectedIndex);
            }
            else
            {
                ErrorLabel.Text = "Выберите элемент";
            }
        }
    }
}
