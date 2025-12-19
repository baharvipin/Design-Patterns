using ConsoleApp.src.DesignPatterns.Creational.AbstractFactoryMethod;
using ConsoleApp.src.DesignPatterns.Creational.Builder;
using ConsoleApp.src.DesignPatterns.Creational.FactoryMethod;
using ConsoleApp.src.DesignPatterns.Creational.FactoryMethod.AnimalExample;
using ConsoleApp.src.DesignPatterns.Creational.FactoryMethod.TransportExample;
using ConsoleApp.src.DesignPatterns.Creational.Singleton;
using ConsoleApp.src.OOPsConcepts.Abstraction.Payment;
using ConsoleApp.src.OOPsConcepts.Inheritance;

Console.WriteLine("Hello, World!");
 var a = new SingletonExecute();
 a.Run();
 
 IDocument doc1 = DocumentFactory.CreateDocument("pdf");
 doc1.Open();
 
 IDocument doc2 = DocumentFactory.CreateDocument("word");
 doc2.Open();
 
 IDocument doc3 = DocumentFactory.CreateDocument("excel");
 doc3.Open();

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

Application app1 = new Application(new WindowsFactory());
app1.RenderUI();

Application app2 = new Application(new MacFactory());
app2.RenderUI();


ICarBuilder builder = new SportsCarBuilder();
builder.SetEngine("V8").SetWheels(4).SetGPS("Advanced GPS");

Console.WriteLine("Starting the car building process...");
builder.Build();

PaymentBase payment;

payment = new CreditCardPayment();
payment.MakePayment(2500);
payment.Refund(500);
payment.ShowBalance();

Console.WriteLine();

payment = new PayPalPayment();
payment.MakePayment(4000);
payment.Refund(1000);
payment.ShowBalance();


SavingsAccount savings = new SavingsAccount
{
    AccountNumber = "SA123",
    AccountHolder = "Ravi"
};

savings.Deposit(5000);
savings.AddInterest();
savings.ShowBalance();

Console.WriteLine();

CurrentAccount current = new CurrentAccount
{
    AccountNumber = "CA456",
    AccountHolder = "Amit"
};

current.Deposit(2000);
current.Withdraw(2500);
current.ShowBalance();
