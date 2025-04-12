using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    /// <summary>
    /// Хранит информацию о песне.
    /// </summary>
    class Song
    {
        /// <summary>
        /// Наименование песни.
        /// </summary>
        private string _name;
        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _durationSec;
        /// <summary>
        /// Уникальный идентификатор песни.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }
        /// <summary>
        /// Возвращает и задаёт продолжительность песни в секундах. Должно быть целое число от 10 до 1000.
        /// </summary>
        public int DurationSec
        {
            get { return _durationSec; }
            set
            {
                Validator.AssertValueInRange(value, 10, 1000);
                _durationSec = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт уникальный идентификатор песни. Должно быть целое положительное число.
        /// </summary>
        public int ID
        {
            get { return _id; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _id = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название. Должно быть не null.</param>
        /// <param name="durationSec">Продолжительность. Должно быть целое число от 10 до 1000.</param>
        /// <param name="id">Уникальный идентификатор. Должно быть целое положительное число.</param>
        public Song(string name, int durationSec, int id)
        {
            Name = name;
            DurationSec = durationSec;
            ID = id;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {
            
        }
    }
}
