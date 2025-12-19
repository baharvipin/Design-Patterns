using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.OOPsConcepts.Abstraction.Payment
{
    public interface IPayment
    {
        void MakePayment(double amount);
        void Refund(double amount);
    }
}
