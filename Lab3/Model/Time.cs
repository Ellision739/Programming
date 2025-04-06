using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    class Time
    {
        private int _hour;
        private int _minute;
        private int _second;

        public int Hour
        {
            get { return _hour; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23);
                _hour = value;
            }
        }
        public int Minute
        {
            get { return _minute; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59);
                _minute = value;
            }
        }
        public int Second
        {
            get { return _second; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59);
                _second = value;
            }
        }
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public Time()
        {
            
        }
    }
}
