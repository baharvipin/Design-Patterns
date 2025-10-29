using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.Builder
{
    // The issue arises because the methods `SetEngine`, `SetWheels`, and `SetGPS` in the `ICarBuilder` interface return `void`.
    // To fix the issue, these methods need to return the builder instance (`this`) to allow method chaining.

    public interface ICarBuilder
    {
        ICarBuilder SetEngine(string engine); // Changed return type from void to ICarBuilder
        ICarBuilder SetWheels(int wheels);    // Changed return type from void to ICarBuilder
        ICarBuilder SetGPS(string gps);       // Changed return type from void to ICarBuilder
        Car Build();
    }
}
