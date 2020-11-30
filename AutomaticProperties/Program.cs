using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Automatic Properties *****\n");

            Car myCar = new Car();
            myCar.PetName = "Frank";
            myCar.Speed = 55;
            myCar.Color = "Red";

            Console.WriteLine("Your car is named {0}? Thats odd...", myCar.PetName);
            myCar.DisplayStats();

            //insert Car object in Garage object
            Garage gar = new Garage();
            gar.MyAuto = myCar;
            //Get number of cars in garage
            Console.WriteLine("Number of Cars in garage: {0}", gar.NumberOfCars);
            //Get Name of Car in garage
            Console.WriteLine($"Your car is named: {gar.MyAuto.PetName}");

            Console.ReadLine();
        }
    }
}
