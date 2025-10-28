using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.AbstractFactoryMethod
{
    public class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering a Mac checkbox");
    }
}
