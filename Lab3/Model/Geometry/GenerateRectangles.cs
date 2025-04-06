using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Lab3.Model.Geometry
{
    //class GenerateRectangles
    //{
    //    Random random = new Random();
    //    public double Length { get; set; }
    //    public double Width { get; set; }
    //    public string Color { get; set; }
    //    string[] colors = { "red", "green", "blue", "yellow", "black", "gray" };
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public GenerateRectangles()
    //    {
    //        Length = Math.Round(1 + (100 - 1) * random.NextDouble(), 1);
    //        Width = Math.Round(1 + (100 - 1) * random.NextDouble(), 1);
    //        Color = colors[random.Next(colors.Length)];
    //        X = random.Next(0, 100);
    //        Y = random.Next(0, 100);
    //    }
    //}
    static class GenerateRectangles
    {
        static Random random = new Random();
        static string[] colors = { "red", "green", "blue", "yellow", "black", "gray" };
        static public double GetLengthOrWidth()
        {
            return Math.Round(1 + (100 - 1) * random.NextDouble(), 1);
        }
        static public int GetXOrY()
        {
            return random.Next(0, 100);
        }
        static public string GetColor()
        {
            return colors[random.Next(colors.Length)];
        }
    }
}
