using ConsoleApp.src.DesignPatterns.Creational.AbstractFactoryMethod;
using ConsoleApp.src.DesignPatterns.Creational.FactoryMethod;
using ConsoleApp.src.DesignPatterns.Creational.FactoryMethod.AnimalExample;
using ConsoleApp.src.DesignPatterns.Creational.FactoryMethod.TransportExample;
using ConsoleApp.src.DesignPatterns.Creational.Singleton;

Console.WriteLine("Hello, World!");
//var a = new SingletonExecute();
//a.Run();

//IDocument doc1 = DocumentFactory.CreateDocument("pdf");
//doc1.Open();

//IDocument doc2 = DocumentFactory.CreateDocument("word");
//doc2.Open();

//IDocument doc3 = DocumentFactory.CreateDocument("excel");
//doc3.Open();

Dog d = new Dog(); // ✅ allowed
d.MakeSound();
d.Eat();

Logistics logistics;

// Client chooses the type dynamically
logistics = new RoadLogistic();
logistics.PlanDelivery();

logistics = new WaterLogistic();
logistics.PlanDelivery();



IGUIFactory factory;

// Choose the family dynamically
string osType = "Windows";

if (osType == "Windows")
    factory = new WindowsFactory();
else
    factory = new MacFactory();

Application app = new Application(factory);
app.RenderUI();