using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Servies
{
    /// <summary>
    /// Валидатор для проверки значений свойств.
    /// </summary>
    class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки и выбрасывает исключение, 
        /// если она превышает указанное значение.
        /// </summary>
        /// <param name="value">Значение строки для проверки.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        /// <param name="propertyName">Имя свойства, которое проверяется.</param>
        /// <exception cref="ArgumentException">Если строка длиннее допустимого значения.</exception>
        public void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }
    }
}
