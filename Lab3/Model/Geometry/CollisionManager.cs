using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model.Geometry
{
    static class CollisionManager
    {
        public static bool IsCollision(Rectangles rectangle1, Rectangles rectangle2)
        {
            bool collisionX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X) < (rectangle1.Width / 2 + rectangle2.Width / 2);
            bool collisionY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) < (rectangle1.Length / 2 + rectangle2.Length / 2);

            return collisionX && collisionY;
        }

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
