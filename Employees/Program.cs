using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");

            SalesPerson fred = new SalesPerson();
            fred.Age = 32;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2332", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson frank = new SalesPerson("Frank", 43, 93, 3000, "932-23-3232", 31);
            frank.GiveBonus(200);
            frank.DisplayStats();

            Console.ReadLine();
        }
    }
}
