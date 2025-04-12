using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Model;

namespace Lab3.View.Panels
{
    /// <summary>
    /// Отображение информации для выбранного фильма с возможностью редактирования
    /// </summary>
    public partial class MoviePanel : UserControl
    {
        public MoviePanel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Айди для фильма из MoviesBox.
        /// </summary>
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

        //Создание экземпляров фильмов
        Movie movie1 = new Movie(name1, duration1, year1, genre1, rating1);
        Movie movie2 = new Movie(name2, duration2, year2, genre2, rating2);
        Movie movie3 = new Movie(name3, duration3, year3, genre3, rating3);
        Movie movie4 = new Movie(name4, duration4, year4, genre4, rating4);
        Movie movie5 = new Movie(name5, duration5, year5, genre5, rating5);

        private void MoviesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameBoxMovies.Clear();
            durationBox.Clear();
            yearBox.Clear();
            genreBox.Clear();
            ratingBox.Clear();
            resultLabelMovies.Text = "";

            movieID = MoviesBox.SelectedIndex;
            switch (movieID) //Вывод значений в текстбоксы
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

        private void rememberValuesMovie_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (movieID) //Сохранение изменённых значений для экземпляров класса
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
        /// <summary>
        /// Ищет фильм с наибольшим рейтингом.
        /// </summary>
        /// <param name="ratings">Массив рейтингов у созданных фильмов.</param>
        /// <returns>Возвращает индекс фильма</returns>
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
        private void findMovie_Click_1(object sender, EventArgs e)
        {
            double[] rating = { movie1.Rating, movie2.Rating, movie3.Rating, movie4.Rating, movie5.Rating }; //Массив с рейтингом всех фильмов
            resultLabelMovies.Text = FindMovieWithRating(rating).ToString(); //Вывод индекса фильма
        }
    }
}
