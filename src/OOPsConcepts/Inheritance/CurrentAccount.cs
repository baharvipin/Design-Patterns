using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.OOPsConcepts.Inheritance
{
    public class CurrentAccount : BankAccount
    {
        private const double OverdraftLimit = 1000;

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ₹{amount}. Remaining balance: ₹{Balance}");
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded!");
            }
        }
    }

}
