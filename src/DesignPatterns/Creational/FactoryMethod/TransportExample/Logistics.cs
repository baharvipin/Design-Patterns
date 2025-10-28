using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.FactoryMethod.TransportExample
{
    public abstract class Logistics
    {
        public abstract ITransport CreateTransport();
        public void PlanDelivery()
        {
            ITransport transport = CreateTransport();
            transport.Deliver();
        }
    }
}
