namespace ConsoleApp.src.OOPsConcepts.abstract1
{
    public abstract class AbstractionClass1
    {
        public AbstractionClass1(string name)
        {
            Console.WriteLine($"Constructor of AbstractionClass1 called. {name}");
        }
        public abstract void AbstractMethod1(); // Abstract method without implementation
    }

}
