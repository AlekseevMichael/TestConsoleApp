using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");

            SavingAccount s1 = new SavingAccount(50);
            SavingAccount s2 = new SavingAccount(100);

            Console.WriteLine($"Interest rate is: {SavingAccount.InterestRate}");

            SavingAccount.InterestRate = 0.08;
            SavingAccount s3 = new SavingAccount(10000.75);

            Console.WriteLine("Interest rate is: {0}", SavingAccount.InterestRate);

            Console.ReadLine();
        }
    }
}
