using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Nullable Data *****");
            DatabaseReader dr = new DatabaseReader();

            //get int value from database
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
                Console.WriteLine($"Value of 'i' is: {i.Value}");
            else
                Console.WriteLine("Value of 'i' is not defined");
            //Output: Value of 'i' is not defined

            //get bool value from database
            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
                Console.WriteLine($"Value of 'b' is: {b.Value}");
            else
                Console.WriteLine("Value of 'b' is not defined");
            //Output: Value of 'b' is: true

            //The null-coalescing operator in use
            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine($"Value of myData: {myData}");
            bool myBool = dr.GetBoolFromDatabase() ?? false;
            Console.WriteLine($"Value of myBool: {myBool}");
            //Output:   Value of myData: 100
            //          Value of myBool: true

            TesterMethod(null);
            //Output: Your array is null

            TesterMetodWithNullOperator(null);
            //Output: You sent me   arguments

            Console.ReadLine();
        }

        static void LocalNullableVariables()
        {
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];
            //Error! string is refType for C# 7.3 => C# 8.0 (avail)
            //string? nullableString = "Ooops";
        }

        static void LocalNullableVariablesNullableUse()
        {
            //Define var with System.Nullable<T> have same result
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        }

        static void TesterMethod(string[] args)
        {
            //before access to array we must null check
            if (args != null)
                Console.WriteLine($"You sent me {args.Length} arguments");
            else
                Console.WriteLine($"Your array is null");
        }

        static void TesterMetodWithNullOperator(string[] args)
        {
            Console.WriteLine($"You sent me {args?.Length} arguments");
        }
    }
}
