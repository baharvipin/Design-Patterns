using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.FactoryMethod.TransportExample
{
    public class WaterLogistic : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
