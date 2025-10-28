using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.FactoryMethod.TransportExample
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by truck");
        }
    }
}
