using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitialazer
{
    enum PointColor
    {
        LightBlue,
        BloodyRed,
        Gold
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }
        public Point() : this(PointColor.BloodyRed) { }
        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"X: {X}, Y: {Y}.");
            Console.WriteLine("Point is: {0}", Color);
        }
    }
}
