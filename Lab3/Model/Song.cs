using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    internal class Song
    {
        private string _name;
        private int _durationSec;
        private int _id;

        public string Name { get { return _name; } set { _name = value; } }
        public int DurationSec
        {
            get { return _durationSec; }
            set
            {
                Validator.AssertValueInRange(value, 10, 1000);
                _durationSec = value;
            }
        }
        public int ID
        {
            get { return _id; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _id = value;
            }
        }
        public Song(string name, int durationSec, int id)
        {
            Name = name;
            DurationSec = durationSec;
            ID = id;
        }
        public Song()
        {
            
        }
    }
}
