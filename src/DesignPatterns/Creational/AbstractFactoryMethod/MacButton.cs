using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.AbstractFactoryMethod
{
    public class MacButton : IButton
    {
        public void Paint() => Console.WriteLine("Rendering a Mac button");
    }
}
