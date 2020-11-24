using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    public class InterestEarningAccount : BankAccount
    {
        //Объявление конструктора класса наследника
        public InterestEarningAccount(string name, decimal InitialBalance) : base(name, InitialBalance)
        {

        }

        public override void PerformMonthEndTransaction()
        {
            if (Balance > 500m)
            {
                var interest = Balance * 0.5m;
                MakeDeposit(interest, DateTime.Now, "Apply monthly interest");
            }
        }
    }
}
