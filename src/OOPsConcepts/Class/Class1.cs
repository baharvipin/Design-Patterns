using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.OOPsConcepts.Class
{
    public class Class1
    { 
        public int X; 
        private Class1()
        {
            X = 10;
            // Fixed the constructor to remove the invalid parameter 'i' in the WriteLine method.
            Console.WriteLine("This is constructor");
        }

        public int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}
