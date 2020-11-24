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

        //Вернуть стандартный конструкторЮ который
        //будет устанавливать все члены данных в стандарные значения.
        public Motorcycle() { }

        //Специальный конструктор
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
    }
}
