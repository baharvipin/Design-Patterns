using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.FactoryMethod.AnimalExample
{
    public abstract class Animal
    {
        public abstract void MakeSound(); // abstract method (no body)

        public void Eat() // normal method (with body)
        {
            Console.WriteLine("Animal is eating");
        }
    }

}
