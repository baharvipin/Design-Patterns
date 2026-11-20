//using ConsoleApp.src.DesignPatterns.Creational.AbstractFactoryMethod;
//using ConsoleApp.src.DesignPatterns.Creational.Builder;
//using ConsoleApp.src.DesignPatterns.Creational.FactoryMethod;
//using ConsoleApp.src.DesignPatterns.Creational.FactoryMethod.AnimalExample;
//using ConsoleApp.src.DesignPatterns.Creational.FactoryMethod.TransportExample;
//using ConsoleApp.src.DesignPatterns.Creational.Singleton;
//using ConsoleApp.src.OOPsConcepts.Abstraction.Payment;
//using ConsoleApp.src.OOPsConcepts.Inheritance;

//Console.WriteLine("Hello, World!");
// var a = new SingletonExecute();
// a.Run();

// IDocument doc1 = DocumentFactory.CreateDocument("pdf");
// doc1.Open();

// IDocument doc2 = DocumentFactory.CreateDocument("word");
// doc2.Open();

// IDocument doc3 = DocumentFactory.CreateDocument("excel");
// doc3.Open();

//Dog d = new Dog(); // ✅ allowed
//d.MakeSound();
//d.Eat();

//Logistics logistics;

//// Client chooses the type dynamically
//logistics = new RoadLogistic();
//logistics.PlanDelivery();

//logistics = new WaterLogistic();
//logistics.PlanDelivery();

//IGUIFactory factory;

//// Choose the family dynamically
//string osType = "Windows";

//if (osType == "Windows")
//    factory = new WindowsFactory();
//else
//    factory = new MacFactory();

//Application app1 = new Application(new WindowsFactory());
//app1.RenderUI();

//Application app2 = new Application(new MacFactory());
//app2.RenderUI();


//ICarBuilder builder = new SportsCarBuilder();
//builder.SetEngine("V8").SetWheels(4).SetGPS("Advanced GPS");

//Console.WriteLine("Starting the car building process...");
//builder.Build();

//PaymentBase payment;

//payment = new CreditCardPayment();
//payment.MakePayment(2500);
//payment.Refund(500);
//payment.ShowBalance();

//Console.WriteLine();

//payment = new PayPalPayment();
//payment.MakePayment(4000);
//payment.Refund(1000);
//payment.ShowBalance();


//SavingsAccount savings = new SavingsAccount
//{
//    AccountNumber = "SA123",
//    AccountHolder = "Ravi"
//};

//savings.Deposit(5000);
//savings.AddInterest();
//savings.ShowBalance();

//Console.WriteLine();

//CurrentAccount current = new CurrentAccount
//{
//    AccountNumber = "CA456",
//    AccountHolder = "Amit"
//};

//current.Deposit(2000);
//current.Withdraw(2500);
//current.ShowBalance();

//namespace ConstructorDemo
//{
//    public delegate void Notify(string message);
//    public delegate void Operation(int a, int b);
//    public class StaticConstructor
//    {
//        public const int constantCount = 5; // ✅ allowed
//        readonly int notifyCount = 10;
//        static int staticCount = 1;
//        static StaticConstructor()
//        {
//            Console.WriteLine("Static constructor called.");
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine($"Main method Start");
//            Console.WriteLine($"Static Count: {staticCount}");
//            Console.WriteLine($"Main method End");
//        }
//    }
//}

using ConsoleApp.src.LINQ;
namespace PolymorphismDemo
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello from the static method!");
        }

        public delegate void MyDelegate();

        static async Task Main(string[] args)
        {
            MyDelegate myDelegate = SayHello;
            myDelegate();
            var employees = new List<Employee>
{
    new() { Id = 1, Name = "Amit", Department = "IT", Salary = 60000, Age = 28, City = "Indore", IsActive = true },
    new() { Id = 2, Name = "Neha", Department = "HR", Salary = 45000, Age = 25, City = "Bhopal", IsActive = true },
    new() { Id = 3, Name = "Rahul", Department = "IT", Salary = 80000, Age = 32, City = "Indore", IsActive = true },
    new() { Id = 4, Name = "Priya", Department = "Finance", Salary = 55000, Age = 29, City = "Pune", IsActive = false },
    new() { Id = 5, Name = "Vikas", Department = "HR", Salary = 45000, Age = 27, City = "Bhopal", IsActive = true },
    new() { Id = 6, Name = "Ankit", Department = "IT", Salary = 75000, Age = 35, City = "Mumbai", IsActive = false },
    new() { Id = 7, Name = "Sneha", Department = "Finance", Salary = 65000, Age = 30, City = "Indore", IsActive = true },
    new() { Id = 8, Name = "Rohit", Department = "Sales", Salary = 40000, Age = 24, City = "Pune", IsActive = true },
    new() { Id = 9, Name = "Pooja", Department = "Sales", Salary = 50000, Age = 26, City = "Mumbai", IsActive = false },
    new() { Id = 10, Name = "Karan", Department = "IT", Salary = 90000, Age = 38, City = "Bhopal", IsActive = true },
    new() { Id = 11, Name = "Meena", Department = "HR", Salary = 52000, Age = 31, City = "Indore", IsActive = true },
    new() { Id = 12, Name = "Arjun", Department = "Sales", Salary = 48000, Age = 29, City = "Mumbai", IsActive = true }
};
            //var departmentsordthen = employees.OrderBy(e => e.Department).ThenByDescending(k => k.Salary);
            //foreach (var item in departmentsordthen)
            //{
            //    Console.WriteLine($"{item.Department} - {item.Salary}");
            //}

            //var employeeswhose = employees.GroupBy(g => g.Department).SelectMany(s => s.Where(e => s.Average(k => k.Salary) > e.Salary));
            var k = employees.Select(s => new { Name = s.Name, AnnualSaray = s.Salary * 12 });

            //var empMore4char = employees.Where(s => s.Name.Length > 4);

            //var secondHighestSalary = employees.OrderByDescending(e => e.Salary).Skip(1).FirstOrDefault();
            //Console.WriteLine($"Second highest salary employee details: {secondHighestSalary?.Name}, {secondHighestSalary?.Salary}");
            //var thirdHighestSalary = employees.OrderByDescending(e => e.Salary).Skip(2).FirstOrDefault();
            //Console.WriteLine($"Third highest salary employee details: {thirdHighestSalary?.Name}, {thirdHighestSalary?.Salary}");

            //var d = employees.GroupBy(e => e.Department).Where(w => w.Average(w => w.Salary) > 55000).Select(s => new { Department = s.Key, AverageSalary = s.Average(s => s.Salary) });
            //foreach (var item in d)
            //{
            //    Console.WriteLine($"{item.Department} - {item.AverageSalary}");
            //}


            //var maximumSalaryInDepartment = employees.GroupBy(g => g.Department).Where(k => k.Count() > 2).Select(s => new { Department = s.Key, MaxSalary = s.Max(s => s.Salary), ActiveCount = s.Count() });
            //foreach (var item in maximumSalaryInDepartment)
            //{
            //    Console.WriteLine($"{item.Department}- {item.MaxSalary} - {item.ActiveCount}");
            //}

            //var groupemployee = employees.GroupBy(e => e.Department).Select(s => new { Department = s.Key, TotalSalary = s.Sum(s => s.Salary) });
            //Console.WriteLine($"Total salary of employees in each department:");
            //foreach (var item in groupemployee)
            //{
            //    Console.WriteLine($"Department: {item.Department}, Total Salary: {item.TotalSalary}");
            //}

            //var employeeWhoseSalary = employees.Where(e => e.Salary > 200000).FirstOrDefault();
            //var uniqueDepartmentNames = employees.Select(e => e.Department).Distinct();
            //Console.WriteLine("Unique Department Names:");
            //foreach (var department in uniqueDepartmentNames)
            //{
            //    Console.WriteLine(department);
            //}

            //var checkanyemployeebelongstosales = employees.Any(e => e.Department == "Sales");
            //Console.WriteLine($"Is there any employee belonging to Sales department? {checkanyemployeebelongstosales}");


            //var check = employees.Any(e => e.Salary > 80000);
            //Console.WriteLine($"Is there any employee with salary greater than 80,000? {check}");
            //var checkAllEmployeeActive = employees.All(e => e.IsActive);
            //Console.WriteLine($"Are all employees active? {checkAllEmployeeActive}");

            //var firstFinanceEmployee = employees.Where(e => e.Department == "Finance").OrderBy(e => e.Id).FirstOrDefault();

            //var lastFinanceEmployee = employees.Where(e => e.Department == "Finance").OrderByDescending(e => e.Id).FirstOrDefault();


            //var LowestPaidemployess = employees.OrderBy(e => e.Salary).Take(1);
            //Console.WriteLine($"Lowest paid employee details:");
            //foreach (var item in LowestPaidemployess)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //}

            //var highestPaidemployee = employees.OrderByDescending(e => e.Salary).Take(1);
            //Console.WriteLine($"Highest paid employee details:");
            //foreach (var item in highestPaidemployee)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //}

            //var highestSalary = employees.OrderByDescending(e => e.Salary).Select(e => e.Salary).FirstOrDefault();
            //Console.WriteLine(highestSalary);

            //var averageEmployeeSalary = employees.Average(a => a.Salary);

            //Console.WriteLine($"Average salary of all employees: {averageEmployeeSalary}");

            //var totalSalary = employees.Sum(s => s.Salary);
            //Console.WriteLine($"Total salary of all employees: {totalSalary}");

            //var countEmployeesineachdepartment = employees.GroupBy(e => e.Department).Select(s => new { Department = s.Key, NumberOfEmployee = s.Count() }).ToList();
            //foreach (var item in countEmployeesineachdepartment)
            //{
            //    Console.WriteLine($"Department: {item.Department}, Number of Employees: {item.NumberOfEmployee}");
            //}

            //var skip5Employees = employees.Skip(5).ToList();
            //Console.WriteLine($"Find employees after skipping first 5 employees.");
            //foreach (var item in skip5Employees)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //}

            //var totalNumberOfEmployees = employees.Count();
            //Console.WriteLine($"Total number of employees: {totalNumberOfEmployees}");

            //var countActiveEmployees = employees.Where(e => e.IsActive).Count();
            //Console.WriteLine($"Total number of active employees: {countActiveEmployees}");

            //// Find all employees working in IT.

            //Console.WriteLine($"all employees working in IT");
            //var itEmployeesList = employees.Where(e => e.Department == "IT").ToList();
            //foreach (var item in itEmployeesList)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");

            //}
            //// Find employees whose salary is greater than 50,000.
            //Console.WriteLine($"Find employees whose salary is greater than 50,000.");
            //var employeeSalaryGreaterThan50000 = employees.Where(e => e.Salary > 50000).ToList();
            //foreach (var item in employeeSalaryGreaterThan50000)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //}

            //var empoloyeeworkinginhrandearninggtreather45000 = employees.Where(e => e.Salary > 45000 && e.Department == "HR").ToList();

            //Console.WriteLine($"Find employees working in HR and earning greater than 45,000.");
            //foreach (var item in empoloyeeworkinginhrandearninggtreather45000)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //}
            ///// Find employees whose salary is between 50,000 and 80,000.

            //Console.WriteLine($"Find employees whose salary is between 50,000 and 80,000.");

            //var employeeinbetween50000and80000 = employees.Where(e => e.Salary > 50000 && e.Salary < 80000).ToList();
            //foreach (var item in employeeinbetween50000and80000)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //}

            //var employeeNameA = employees.Where(e => e.Name.StartsWith("A")).ToList();
            //Console.WriteLine($"Find employees whose name starts with 'A'.");
            //foreach (var item in employeeNameA)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //}

            //var employeeNameEndsWithA = employees.Where(e => e.Name.EndsWith("A")).ToList();
            //Console.WriteLine($"Find employees whose name ends with 'A'.");
            //foreach (var item in employeeNameEndsWithA)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //}

            //Console.WriteLine($"Find employees whose name contains 'A'.");

            //var employeeNameContainsA = employees.Where(e => e.Name.Contains("A")).ToList();
            //foreach (var item in employeeNameContainsA)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //} 

            //var employeeName = employees.Select(e => e.Name).ToList();
            //foreach (var item in employeeName)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //var employeeSortSalaryAscending = employees.OrderBy(e => e.Salary).ToList();
            //Console.WriteLine($"Find employees whose salary is sorted in ascending order.");
            //foreach (var item in employeeSortSalaryAscending)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //}
            //var first5Employees = employees.Take(5).ToList();
            //Console.WriteLine($"Find first 5 employees.");
            //foreach (var item in first5Employees)
            //{
            //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Department: {item.Department}, Salary: {item.Salary}, Age: {item.Age}, City: {item.City}, IsActive: {item.IsActive}");
            //}
        }

        //static void Main(string[] args, dynamic employees)
        //    var listOfEmployeesgreaterthan30 = ((IEnumerable<dynamic>)employees)
        //        .Where((Func<dynamic, bool>)(e => e.Age > 30))
        //        .ToList();
        //    Console.ReadKey();
        //}
    }
}