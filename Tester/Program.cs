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
            Card card = new Card();
            var x = card.GetCardById(12345);

            var c1 = x?.ID ?? 0;
            var c2 = x?.Name ?? "Not found";

            Console.WriteLine($"c1 = {x?.ID ?? 0}, c2 = {x?.Name ?? "Not found"}.");

            DateTime from = new DateTime(2020, 11, 30);

            DateTime to = from.AddDays(1);
            to = to.AddSeconds(-1);

            Console.WriteLine($"to = {from}");


            Console.ReadLine();
        }
    }
}
