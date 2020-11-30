using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProperties
{
    class Car
    {
        //Automatic prop, fields not needed now!
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public int MyReadOnlyProp { get; }
        //Prop for write only? Error!!
        //public int MyWriteOnlyProp { set; }

        public void DisplayStats ()
        {
            Console.WriteLine($"Car Name: {PetName}.");
            Console.WriteLine("Speed: {0}.", Speed);
            Console.WriteLine("Color: " + Color + ".");
        }

    }
}
