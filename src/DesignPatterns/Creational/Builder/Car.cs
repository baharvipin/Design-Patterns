using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.Builder
{
    public class Car
    {
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public string GPS { get; set; }

        public override string ToString()
        {
            return $"Car with Engine: {Engine}, Wheels: {Wheels}, GPS: {GPS}";
        }
    }

}
