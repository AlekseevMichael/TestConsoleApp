using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitialazer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Sintax *****");

            //Create Point object with manualy set value
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            //Create Point object with special ctor
            Point secondPoint = new Point(20, 20);
            secondPoint.DisplayStats();

            //Create Point object with Object init sintax
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();

            //Use special ctor but Object Init Sintax sets X and Y = 100
            Point pt = new Point(10, 16) { X = 100, Y = 100 };
            pt.DisplayStats();

            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();

            //Use OIS
            Rectangle rect = new Rectangle()
            {
                TopLeft = new Point () { X = 10, Y = 10 },
                BottomRight = new Point (PointColor.LightBlue) { X = 200, Y = 200 }
            };
            rect.DisplayStats();

            //Analog
            //Rectangle r = new Rectangle();
            //r.TopLeft = new Point();
            //r.TopLeft.X = 10;
            //r.TopLeft.Y = 10;
            //r.BottomRight = new Point();
            //r.BottomRight.X = 200;
            //r.BottomRight.Y = 200;
            //r.BottomRight.Color = PointColor.LightBlue;


            Console.ReadLine();
        }
    }
}
