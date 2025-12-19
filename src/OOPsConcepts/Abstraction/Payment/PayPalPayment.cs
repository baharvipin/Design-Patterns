using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.OOPsConcepts.Abstraction.Payment
{
    // PayPal Payment Implementation
    public class PayPalPayment : PaymentBase
    {
        public override void MakePayment(double amount)
        {
            GenerateTransactionId();
            Console.WriteLine($"Processing PayPal Payment of ₹{amount}");
            Balance += amount; // Update balance
        }

        public override void Refund(double amount)
        {
            Console.WriteLine($"Refunding ₹{amount} to PayPal Account");
            Balance -= amount; // Update balance
        }
    }
}
