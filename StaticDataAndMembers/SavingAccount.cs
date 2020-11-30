using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingAccount
    {
        public double currBalance;
        private static double currInterestRate;

        public static double InterestRate
        {
            get { return currInterestRate; }
            set { currInterestRate = value; }
        }

        public SavingAccount(double balance)
        {
            currBalance = balance;
        }

        static SavingAccount()
        {
            Console.WriteLine("In static ctor");
            currInterestRate = 0.04;
        }
    }
}
