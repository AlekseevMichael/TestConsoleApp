using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal InitialBalance, decimal creditLimit) : base (name, InitialBalance, -creditLimit)
        {

        }

        public override void PerformMonthEndTransaction()
        {
            if (Balance < 0)
            {
                //Negate the balance to get a positive interest charge:
                var interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }
    }
}
