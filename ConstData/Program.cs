using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public readonly double readonlyPI; //Значение может устанавливаться только внутри конструктора класса
        //Не является не явно статической

        public const double PI = 3.14; //Не может объявиться без инициализации
        //Константа не явно статическая

        public MyMathClass()
        {
            readonlyPI = 3.14;
        }

        public void TryChangeReadonlyVar()
        {
           // readonlyPI = 30; ERROR Readonly var
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun woth Const *****\n");
            Console.WriteLine($"The value of PI = {MyMathClass.PI}");

            //Error couldnt change const val
            //MyMathClass.PI = 4;

            LocalConstStringVar();

            Console.ReadLine();
        }

        static void LocalConstStringVar()
        {
            const string fixedStr = "Fixed string data";
            Console.WriteLine(fixedStr);
        }
    }
}
