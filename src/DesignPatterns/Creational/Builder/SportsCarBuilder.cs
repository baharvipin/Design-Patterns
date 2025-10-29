using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.Builder
{
    // Ensure that the implementation of ICarBuilder also returns `this` for the chaining methods.
    public class SportsCarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public ICarBuilder SetEngine(string engine)
        {
            _car.Engine = engine;
            return this; // Return the builder instance
        }

        public ICarBuilder SetWheels(int wheels)
        {
            _car.Wheels = wheels;
            return this; // Return the builder instance
        }

        public ICarBuilder SetGPS(string gps)
        {
            _car.GPS = gps;
            return this; // Return the builder instance
        }

        public Car Build()
        {
            Console.WriteLine("Building a sports car...");
            Console.WriteLine(_car.ToString());
            Console.WriteLine("Sports car built successfully!");
            return _car;
        }
    }

}
