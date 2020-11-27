using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****");

            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            //Using get/set properties
            emp.Name = "Marv";
            Console.WriteLine($"Employee is named: {emp.Name}");

            Employee emp2 = new Employee();
            emp2.Name = "Xena the warrior princess";
            Console.WriteLine($"Employee is named: {emp2.Name}");

            Console.ReadLine();
        }
    }
}
