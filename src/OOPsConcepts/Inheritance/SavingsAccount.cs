using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.OOPsConcepts.Inheritance
{
    public class SavingsAccount : BankAccount
    {
        private const double InterestRate = 0.04; // 4%

        private const double MinimumBalance = 500;
        public override void Withdraw(double amount)
        {
            if (amount > 0 && (Balance - amount) >= MinimumBalance)
            {
                Balance -= amount;
                Console.WriteLine($"{AccountHolder}: Withdrawn ₹{amount}");
            }
            else
            {
                Console.WriteLine($"{AccountHolder}: Cannot withdraw ₹{amount}. Maintain minimum balance ₹{MinimumBalance}.");
            }
        }

        public void AddInterest()
        {
            double interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Interest of ₹{interest} added. New balance: ₹{Balance}");
        }
    }

}
