using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        public void SetDriverName(string name)
        {
            this.driverName = name;
        }

        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeeewwww!");
            }
        }

        //Вернуть стандартный конструктор, который
        //будет устанавливать все члены данных в стандарные значения.
        //public Motorcycle() { }

        //Специальный конструктор
        //public Motorcycle(int intensity)
        //{
        //    driverIntensity = intensity;
        //}

        public Motorcycle() 
        {
            Console.WriteLine("In default ctor.");
        }

        public Motorcycle(int intensity) : this(intensity, "") 
        {
            Console.WriteLine("In ctor taking an int.");
        }

        public Motorcycle(string name) : this(0, name) 
        {
            Console.WriteLine("In ctor taking a string.");
        }

        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In master ctor.");
            if (intensity > 10)
                intensity = 10;
            driverIntensity = intensity;
            driverName = name;
        }

        //ctor с необязательными аргументами, делающий тоже самое, но проще
        //public Motorcycle(int intensity = 0, string name = "")
        //{
        //    if (intensity > 10)
        //        intensity = 10;
        //    driverIntensity = intensity;
        //    driverName = name;
        //}
    }
}
