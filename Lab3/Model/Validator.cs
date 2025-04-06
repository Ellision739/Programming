using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Lab3.Model
{
    static class Validator
    {
        public static void AssertOnPositiveValue(int value, [CallerMemberName] string propertyName = null) 
        { 
            if (value < 0)
            {
                throw new ArgumentException($"Требуется положительное значение в {propertyName}");
            }
        }
        public static void AssertOnPositiveValue(double value, [CallerMemberName] string propertyName = null)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Требуется положительное значение в {propertyName}");
            }
        }
        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string propertyName = null)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Требуется значение в {propertyName}, находящееся в промежутке от {min} до {max}");
            }
        }
        public static void AssertValueInRange(double value, double min, double max, [CallerMemberName] string propertyName = null)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Требуется значение в {propertyName}, находящееся в промежутке от {min} до {max}");
            }
        }
    }
}
