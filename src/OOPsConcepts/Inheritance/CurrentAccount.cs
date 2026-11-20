namespace ConsoleApp.src.OOPsConcepts.Inheritance
{
    public class CurrentAccount : BankAccount
    {
        private const double OverdraftLimit = 1000;

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ₹{amount}. Current balance: ₹{Balance}");
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ₹{amount}. Remaining balance: ₹{Balance}");
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded!");
            }
        }
    }

}
