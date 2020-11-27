using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Classes *****");

            //Its works
            TimeUtilClass.PrintTime();
            TimeUtilClass.PrintDate();

            //Error we cant create objects of static class
            //TimeUtilClass u = new TimeUtilClass;

            Console.ReadLine();
        }
    }
}
