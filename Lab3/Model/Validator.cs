using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Lab3.Model
{
    /// <summary>
    /// Хранит функции для валидации.
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Проверяет целое число, что оно больше нуля.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке. Указывать не нужно, встаёт автоматически.</param>
        /// <exception cref="ArgumentException">Ошибка подаваемого аргумента</exception>
        public static void AssertOnPositiveValue(int value, [CallerMemberName] string propertyName = null) 
        { 
            if (value < 0)
            {
                throw new ArgumentException($"Требуется положительное значение в {propertyName}");
            }
        }
        /// <summary>
        /// Проверяет вещественное число, что оно больше нуля.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке. Указывать не нужно, встаёт автоматически.</param>
        /// <exception cref="ArgumentException">Ошибка подаваемого аргумента</exception>
        public static void AssertOnPositiveValue(double value, [CallerMemberName] string propertyName = null)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Требуется положительное значение в {propertyName}");
            }
        }
        /// <summary>
        /// Проверяет целое число на то, чтобы оно находилось в правильном диапозоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница диапозона.</param>
        /// <param name="max">Правая граница диапозона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке. Указывать не нужно, встаёт автоматически.</param>
        /// <exception cref="ArgumentException">Ошибка подаваемого аргумента</exception>
        public static void AssertValueInRange(int value, int min, int max, [CallerMemberName] string propertyName = null)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Требуется значение в {propertyName}, находящееся в промежутке от {min} до {max}");
            }
        }
        /// <summary>
        /// Проверяет вещественное число на то, чтобы оно находилось в правильном диапозоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница диапозона.</param>
        /// <param name="max">Правая граница диапозона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке. Указывать не нужно, встаёт автоматически.</param>
        /// <exception cref="ArgumentException">Ошибка подаваемого аргумента</exception>
        public static void AssertValueInRange(double value, double min, double max, [CallerMemberName] string propertyName = null)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Требуется значение в {propertyName}, находящееся в промежутке от {min} до {max}");
            }
        }
    }
}
