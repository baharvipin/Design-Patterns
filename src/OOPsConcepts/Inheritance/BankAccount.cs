using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.OOPsConcepts.Inheritance
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        protected double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ₹{amount}, {AccountNumber} , {AccountHolder}");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: ₹{Balance}");
        }

        // Abstract method — each account type handles withdrawal differently
        public abstract void Withdraw(double amount);

    }

}
