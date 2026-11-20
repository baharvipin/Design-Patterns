namespace ConsoleApp.src.OOPsConcepts.abstract1
{
    public class ConcreteClass1 : AbstractionClass1
    {
        public ConcreteClass1(string name) : base(name)
        {
            Console.WriteLine($"Constructor of ConcreteClass1 called. {name}");
        }
        public override void AbstractMethod1()
        {
            Console.WriteLine("Implementation of AbstractMethod1 in ConcreteClass1.");
        }
    }
}
