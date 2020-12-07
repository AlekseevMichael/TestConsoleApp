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

            CastingExamples();

            //Привести объект Manager к объекту Hexagon невозможно
            //но этот код нормально скомпилируется!
            try
            {
                object ted = new Manager();
                Hexagon hex = (Hexagon)ted;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }

            //Использование ключевого слова as для проверки совместимости приводимых типов
            object[] things = new object[5];
            things[0] = new SalesPerson();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";
            things[4] = new PTSalesPerson();

            foreach (object item in things)
            {
                Employee h = item as SalesPerson;
                if (h == null)
                    Console.WriteLine($"Item is not SalesPerson");
                else
                    Console.WriteLine($"{item} is SalesPerson");
            }

            Console.ReadLine();
        }

        static void CastingExamples()
        {
            //Manager является System.Object, поэтому в переменной
            //типа Object можно хранить ссылку на Manager
            object fran = new Manager("Fran Zappa", 9, 3000, 40000, "111-11-1111", 5);
            //GivePromotion(fran) - Ошибка! Object не является Manager
            GivePromotion((Manager)fran); //Верно! Явное приведение

            //Manager также является Employee
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit); //Пример неявного приведения

            //PTSalesPerson является SalesPerson
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1191", 90);
            GivePromotion(jill); //Примеры неявного приведения
        }

        //В качестве параметра может использоваться любой класс наследник
        static void GivePromotion(Employee emp)
        {
            //Повысить ЗП...
            //Дать место на парковке...
            Console.WriteLine($"{emp.Name} was promoted!");

            if (emp is SalesPerson)
            {
                Console.WriteLine($"{emp.Name} made {((SalesPerson)emp).SalesNumber} sale(s)!\n");
            }
            if (emp is Manager)
            {
                Console.WriteLine($"{emp.Name} had {((Manager)emp).StockOptions} stock options!\n");
            }
        }
    }
}
