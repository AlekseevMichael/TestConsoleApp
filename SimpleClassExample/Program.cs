using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** FUN WITH CLASS TYPES *****\n");

            Motorcycle mc = new Motorcycle();
            mc.PopAWheely();

            //Размещаем в памяти и конфигурируем объект Car
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            //Увеличим скорость автомобиля в несколько раз и выведем новое состояние.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Console.WriteLine();

            //Создаем объект Car по имени Chuck со скоростью 10 миль в час (специальный стандартный конструктор)
            Car chack = new Car();
            chack.PrintState();

            //Создаем объект Car по имени Mary со скоростью 0 миль в час (специальный конструктор)
            Car mary = new Car("Mary");
            mary.PrintState();

            //Создаем объект Car по имени Daisy со скоростью 75 миль в час (специальный конструктор)
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            //Создаем объект Motorcycle с мотоциклистом по имени Tiny
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine($"Rider name is {c.driverName}");

            Console.ReadLine();
        }
    }
}
