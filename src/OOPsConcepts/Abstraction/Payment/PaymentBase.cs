using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.OOPsConcepts.Abstraction.Payment
{
    // Abstract class: provides shared functionality and partial abstraction
    public abstract class PaymentBase : IPayment
    {
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }

        // Common method (shared by all)
        public void GenerateTransactionId()
        {
            TransactionId = Guid.NewGuid().ToString();
            TransactionDate = DateTime.Now;
            Console.WriteLine($"Transaction ID: {TransactionId} at {TransactionDate}");
        }

        // Abstract methods — must be implemented by child classes
        public abstract void MakePayment(double amount);
        public abstract void Refund(double amount);

        // Common method
        private double balance;

        // Protected property to access balance in derived classes safely
        protected double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative!");
            }
        }

        // Common method
        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: ₹{Balance}");
        }

    }

}
