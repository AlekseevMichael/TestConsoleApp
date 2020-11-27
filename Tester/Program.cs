using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2020,9,30);
            Console.WriteLine($"date: {date}");
            date = date.AddDays(1);
            Console.WriteLine($"date after AddDays: {date}");
            for (int i = 0; i < 200; i++)
            {
                date = date.AddSeconds(-1);
                Console.WriteLine($"date after AddSeconds: {date}");
                Console.WriteLine($"Date: {date.Date}");
                Console.WriteLine($"Date: {date.ToShortDateString()}");
            }
            NewClass myClass = new NewClass();
            
            

            Console.ReadLine();
        }
    }
}
