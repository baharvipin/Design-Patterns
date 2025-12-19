using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.OOPsConcepts.Abstraction.Payment
{
    // Credit Card Payment Implementation
    public class CreditCardPayment : PaymentBase
    {
        public override void MakePayment(double amount)
        {
            GenerateTransactionId();
            Console.WriteLine($"Processing Credit Card Payment of ₹{amount}");
            Balance += amount; // Update balance
        }

        public override void Refund(double amount)
        {
            Console.WriteLine($"Refunding ₹{amount} to Credit Card");
            Balance -= amount; // Update balance
        }
    }
}
