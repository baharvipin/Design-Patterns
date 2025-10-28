using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.AbstractFactoryMethod
{
    public class WindowsButton : IButton
    {
        public void Paint() => Console.WriteLine("Rendering a Windows button");
    }
}
