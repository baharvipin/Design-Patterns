namespace ConsoleApp.src.OOPsConcepts.Polymorphism
{
    public class Calculator
    {
        /// <summary>
        /// Polymorphism means one common interface or base type can represent different behaviors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// A. Compile-time polymorphism — Method overloading
        /// Multiple methods have the same name but different parameter lists.
        /// B. Runtime polymorphism — Method overriding
        /// A derived class provides its own implementation of a base class method declared with virtual or abstract.
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

}
