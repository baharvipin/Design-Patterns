namespace ConsoleApp.src.OOPsConcepts.Inheritance
{
    public abstract class BankAccount
    {
        /// <summary>
        /// Inheritance allows a class to acquire accessible members of another class and extend or specialize its behavior.
        /// Avoid it when two classes do not have a genuine is-a relationship or when inheritance creates excessive     coupling. Prefer composition when an object should use another object's functionality without being a specialized version of it.
        /// </summary>
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        protected double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ₹{amount}, {AccountNumber} , {AccountHolder}");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: ₹{Balance}");
        }

        // Abstract method — each account type handles withdrawal differently
        public abstract void Withdraw(double amount);

    }

}
