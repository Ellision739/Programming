using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    class Movie
    {
        private string _name;
        private int _durationMin;
        private int _year;
        private string _genre;
        private double _rating;

        public string Name { get { return _name; } set {  _name = value; } }
        public int DurationMin
        {
            get
            {
                return _durationMin;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ожидается неотрицательное число.");
                }
                _durationMin = value;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1900 || value > 2025)
                {
                    throw new ArgumentException("Ожидается год в промежутке от 1900 до 2025.");
                }
                _year = value;
            }
        }
        public string Genre { get { return _genre; } set { _genre = value; } }
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new ArgumentException("Ожидается значение от 0 до 10.");
                }
                _rating = value;
            }
        }
        public Movie(string name, int durationMin, int year, string genre, double rating)
        {
            Name = name;
            DurationMin = durationMin;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
        public Movie()
        {
            
        }
    }
}
