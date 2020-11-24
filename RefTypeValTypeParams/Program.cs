using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Send ref Type by value
            Console.WriteLine("***** Passing person by value *****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:"); //Before call method
            fred.Display();

            SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call, Person is:");
            fred.Display();
            Console.ReadLine();

            //Send ref Type by ref
            Console.WriteLine("***** Passing person by value *****");
            Person mel = new Person("Mel", 23);
            Console.WriteLine("\nBefore by ref call, Person is:"); //Before call method
            mel.Display();

            SendAPersonByReference(ref mel);
            Console.WriteLine("\nAfter by ref call, Person is:");
            mel.Display();
            Console.ReadLine();
        }

        static void SendAPersonByValue(Person p)
        {
            //Change age val in P?
            p.personAge = 99;

            p = new Person("Nikki", 99);
        }

        static void SendAPersonByReference(ref Person p)
        {
            p.personAge = 555;

            p = new Person("Nikki", 999);
        }
    }
}
