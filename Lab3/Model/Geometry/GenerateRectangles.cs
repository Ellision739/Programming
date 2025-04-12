using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Lab3.Model.Geometry
{
    /// <summary>
    /// Реализует случайную генерацию прямоугольников.
    /// </summary>
    static class GenerateRectangles
    {
        static Random random = new Random();
        /// <summary>
        /// Массив цветов для рандомного выбора.
        /// </summary>
        static string[] colors = { "red", "green", "blue", "yellow", "black", "gray" };
        /// <summary>
        /// Генерирует длину или ширину для прямоугольника.
        /// </summary>
        /// <returns>Возвращает случайное число от 0 до 200.</returns>
        static public double GetLengthOrWidth()
        {
            return random.Next(0, 200);
        }
        /// <summary>
        /// Генерирует X или Y для прямоугольника.
        /// </summary>
        /// <returns>Возвращает случайное число от 15 до 400.</returns>
        static public int GetXOrY()
        {
            return random.Next(15, 400);
        }
        /// <summary>
        /// Генерирует случайный цвет из созданного массива цветов для прямоугольника.
        /// </summary>
        /// <returns> Возвращает случайный цвет.</returns>
        static public string GetColor()
        {
            return colors[random.Next(colors.Length)];
        }
    }
}
