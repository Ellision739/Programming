using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    /// <summary>
    /// Хранит информацию о фильме.
    /// </summary>
    class Movie
    {
        /// <summary>
        /// Наименование фильма.
        /// </summary>
        private string _name;
        /// <summary>
        /// Длительность фильма в минутах.
        /// </summary>
        private int _durationMin;
        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _year;
        /// <summary>
        /// Жанр фильма.
        /// </summary>
        private string _genre;
        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Name { get { return _name; } set {  _name = value; } }
        /// <summary>
        /// Возвращает и задаёт длительность фильма в минутах. Должно быть целое положительное значение.
        /// </summary>
        public int DurationMin
        {
            get { return _durationMin; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _durationMin = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт Год выпуска фильма. Значение должно быть целое число от 1900 по 2025 год. 
        /// </summary>
        public int Year
        {
            get { return _year; }
            set
            {
                Validator.AssertValueInRange(value, 1900, 2025);
                _year = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get { return _genre; } set { _genre = value; } }
        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Значение может быть вещественным числом от 0 до 10.
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10);
                _rating = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название. Должно быть не null.</param>
        /// <param name="durationMin">Продолжительность. Должно быть целое положительное значение.</param>
        /// <param name="year">Год. Значение должно быть целое число от 1900 по 2025 год. </param>
        /// <param name="genre">Жанр. Должно быть не null.</param>
        /// <param name="rating">Рейтинг. Значение может быть вещественным числом от 0 до 10.</param>
        public Movie(string name, int durationMin, int year, string genre, double rating)
        {
            Name = name;
            DurationMin = durationMin;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
            
        }
    }
}
