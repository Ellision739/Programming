using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model.Geometry
{
    /// <summary>
    /// Хранит функции проверки коллизий для прямоугольников и колец.
    /// </summary>
    static class CollisionManager
    {
        /// <summary>
        /// Проверяет, соприкасаются ли два прямоугольника друг с другом.
        /// </summary>
        /// <param name="rectangle1">Первый прявоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если прямоугольники соприкасаются друг с другом,
        /// и false, если нет.</returns>
        public static bool IsCollision(Rectangles rectangle1, Rectangles rectangle2)
        {
            bool collisionX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X) < (rectangle1.Width / 2 + rectangle2.Width / 2);
            bool collisionY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) < (rectangle1.Length / 2 + rectangle2.Length / 2);

            return collisionX && collisionY;
        }

        /// <summary>
        /// Проверяет, соприкасаются ли два кольца друг с другом.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если кольха соприкасаются друг с другом,
        /// и false, если нет.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            if (Math.Sqrt((ring1.Center.X - ring2.Center.X) * (ring1.Center.X - ring2.Center.X) + (ring1.Center.Y - ring2.Center.Y) * (ring1.Center.Y - ring2.Center.Y)) < ring1.OuterRadius + ring2.OuterRadius)
            {
                return true;
            }
            else { return false; }
        }
    }
}
