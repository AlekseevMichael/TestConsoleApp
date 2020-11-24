using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsoleApp.Classes;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Миша", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(1000, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine();

            var giftCard = new GiftCardAccount("VIP Gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "Get expesive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "Buy groceries");
            giftCard.PerformMonthEndTransaction();
            giftCard.MakeDeposit(27.50m, DateTime.Now, "Add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());
            Console.WriteLine();

            var saving = new InterestEarningAccount("Saving account", 10000);
            saving.MakeDeposit(750, DateTime.Now, "Save some money");
            saving.MakeDeposit(1250, DateTime.Now, "Add more savings");
            saving.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            saving.PerformMonthEndTransaction();
            Console.WriteLine(saving.GetAccountHistory());
            Console.WriteLine();

            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 20000);
            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransaction();
            Console.WriteLine(lineOfCredit.GetAccountHistory());
        }
    }
}
