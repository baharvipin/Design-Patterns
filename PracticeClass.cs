namespace ConsoleApp
{
    public class PracticeClass
    {
        public PracticeClass() { }
        public string Description { get; set; }
        public string Type { get; set; }
        public string TypeDescription { get; set; }

        // a class is a blueprint for creating objects, it can have fields, properties, methods, and events. A record is a reference type that provides built-in functionality for encapsulating data. Records are immutable by default and are primarily used for storing data.


        public record EmployeeRecord(string Name, string Designation, int Age);

        public int UpdateValue(out int number)
        {
            number = 0;
            return number;
        }

        public Thread thread = new Thread(() =>
         {
             Console.WriteLine("thread running");

         });
        // thread represts actual execuation of threads
        // a task represnts a peace of asynchronous work has been operated
        // a task represnets asynchronous operation or unit of work
        //int value = 20;

        public Task task = new Task(() =>
        {
            Console.WriteLine("task running");
        });



        private static Task<object> GetCustomerAsync()
        {
            throw new NotImplementedException();
        }

        private static Task<object> GetPolicyAsync()
        {
            throw new NotImplementedException();
        }

        private static Task<object> GetClaimAsync()
        {
            throw new NotImplementedException();
        }

        public async Task CallAsyncFun()
        {
            var claimTask = GetClaimAsync();
            var policyTask = GetPolicyAsync();
            var customerTask = GetCustomerAsync();

            await Task.WhenAll(
                customerTask,
                policyTask,
                claimTask);
        }
        public string? GetName()
        {
            if (employee is { Name: "Vipin", Salary: >= 50000 })
            {
                Console.WriteLine("Employee is eligible for bonus"); return null;
            }
            else
            {
                Console.WriteLine("Employee is not eligible for bonus"); return null;
            }
        }
        public class Employee
        {
            public string? Name { get; set; }
            public decimal Salary { get; set; }
        }

        Employee employee = new()
        {
            Name = "Vipin",
            Salary = 80000
        };
    }
}
