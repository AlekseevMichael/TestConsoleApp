using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****");

            Hexagon hex = new Hexagon("Beth");
            hex.Draw();
            Circle cir = new Circle("Cidny");
            cir.Draw();

            //Создадим массив объектов типа Shape
            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };

            //Пройдем по всем элементам массива и
            //взаимодействуем с полиморфным массивом
            foreach (Shape shape in myShapes)
            {
                shape.Draw();
            }

            Console.ReadLine();
        }
    }
}
