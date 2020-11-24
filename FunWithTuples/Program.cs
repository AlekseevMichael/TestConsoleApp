using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    //Кортежи
    class Program
    {
        static void Main(string[] args)
        {
            //similar 2 code strings
            (string, int, string) values = ("a", 5, "c");
            var value = ("a", 5, "c");

            Console.WriteLine($"First item: {value.Item1}");
            Console.WriteLine($"Second item: {value.Item2}");
            Console.WriteLine($"Third item: {value.Item3}");

            TesterTuple();

            Console.WriteLine("=> Inferred Tuple Names");
            var foo = new { prop1 = "first", prop2 = "Second" };
            var bar = (foo.prop1, foo.prop2);
            Console.WriteLine($"{bar.prop1}, {bar.prop2}");

            FillTheseValues(out int a, out string b, out bool c);

            var sample = FillTheseValues2();
            Console.WriteLine($"Int item: {sample.Item1}");
            Console.WriteLine($"String item: {sample.b}");
            Console.WriteLine($"Bool item: {sample.Item3}");

            Console.ReadLine();
        }

        private static void FillTheseValues(out int a, out string b, out bool c)
            //out Method
        {
            a = 9;
            b = "Enjoy";
            c = true;
        }

        static (int a, string b, bool c) FillTheseValues2()
            //Tuple
        {
            return (9, "Enjoy", true);
        }

        static void TesterTuple()
        {
            //Its right in a both!
            (string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 4, "b");
            var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "b");

            Console.WriteLine($"First item: {valuesWithNames.Item1}");
            Console.WriteLine($"Second item: {valuesWithNames.Item2}");
            Console.WriteLine($"Third item: {valuesWithNames.Item3}");
            //its work in a both!
            Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
        }
    }
}
