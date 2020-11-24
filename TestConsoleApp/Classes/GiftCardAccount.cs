using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    class GiftCardAccount : BankAccount
    {
        private decimal _monthlyDeposit = 0m;
        public GiftCardAccount(string name, decimal InitialBalance, decimal monthlyDeposit = 0) : base(name, InitialBalance) 
            => _monthlyDeposit = monthlyDeposit;

        public override void PerformMonthEndTransaction()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}
