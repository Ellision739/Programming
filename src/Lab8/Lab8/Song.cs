using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    /// <summary>
    /// Хранит данные о песни.
    /// </summary>
    class Song
    {
        /// <summary>
        /// Название песни.
        /// </summary>
		private string _songTitle;
        /// <summary>
        /// Возвращает и задаёт название песни. Колличество символов не должно превышать 50.
        /// </summary>
		public string SongTitle
		{
			get { return _songTitle; }
			set 
			{
				if (value.Length > 50)
				{
					throw new ArgumentException("Колличество символов не должно превышать 50");
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("Название не должно быть пустое");
                }
                _songTitle = value; 
			}
		}
        /// <summary>
        /// Название исполнителя.
        /// </summary>
		private string _artistName;
        /// <summary>
        /// Возвращает и задаёт название исполнителя. Колличество символов не должно превышать 50.
        /// </summary>
		public string ArtistName
		{
			get { return _artistName; }
			set 
			{
                if (value.Length > 50)
                {
                    throw new ArgumentException("Колличество символов не должно превышать 50");
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("Название не должно быть пустое");
                }
                _artistName = value; 
			}
		}
        /// <summary>
        /// Продолжительность песни.
        /// </summary>
		private int _duration;
        /// <summary>
        /// Возвращает и задаёт продолжительность песни. Значение не должно превышать 7200.
        /// </summary>
		public int Duration
		{
			get { return _duration; }
			set 
			{
                if (value > 7200)
                {
                    throw new ArgumentException("Значение не должно превышать 7200");
                }
                if (value <= 0)
                {
                    throw new ArgumentException("Значение быть больше нуля");
                }
                _duration = value; 
			}
		}
        /// <summary>
        /// Хранит жанры песен.
        /// </summary>
		public enum Genre
		{
            Synthpop,
            Rock,
            Pop,
            Rap,
            Classic,
            Indie,
            Alternative,
            Metal,
            Chanson,
            HipHop,
            Ska,
            Trap,
            Patriotic
        }
        /// <summary>
        /// Жанр песни.
        /// </summary>
        private Genre _musicGenre;
        /// <summary>
        /// Возвращает и задаёт жанр песни. Жанр должен быть из перечисления.
        /// </summary>
        public Genre MusicGenre
        {
            get { return _musicGenre; }
            set
            {
                if (!Enum.IsDefined(typeof(Genre), value))
                {
                    throw new ArgumentException("Недопустимый жанр");
                }    
                _musicGenre = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="songTitle">Название песни.</param>
        /// <param name="artistName">Название исполнителя.</param>
        /// <param name="duration">Продолжительность.</param>
        /// <param name="genre">Жанр.</param>
        public Song(string songTitle, string artistName, int duration, string genre)
        {
            SongTitle = songTitle;
            ArtistName = artistName;
            Duration = duration;
            MusicGenre = (Genre)Enum.Parse(typeof(Genre), genre);
        }
    }
}
