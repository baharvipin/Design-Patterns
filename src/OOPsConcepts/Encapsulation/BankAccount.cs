namespace ConsoleApp.src.OOPsConcepts.Encapsulation
{
    /// <summary>
    /// Encapsulation is a fundamental concept in object-oriented programming (OOP) that involves bundling data (attributes) and methods (functions) that operate on that data into a single unit called a class. It restricts direct access to some of the object's components, which can prevent the accidental modification of data and promote data integrity.we commonly achieve encapsulation using access modifiers such as private, public, protected, and properties.
    /// </summary>
    public class BankAccount
    {

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public BankAccount()
        {
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException(
                    "Amount must be positive.");


            if (amount > 0)
            {
                balance += amount;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > balance)
                return false;

            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }

            return true;
        }
    }

    /// <summary>
    ///   How does it work?
    /// - balance is private, so external code cannot modify it directly.
    /// - Deposit() validates the amount before changing the balance.
    /// - Withdraw() prevents withdrawals exceeding the balance.
    /// - Balance exposes read-only access to the current balance.
    ///   Encapsulation: Bundles data and behavior together and defines how they interact.
    ///   Data hiding: Restricts direct access to internal data, often using private.
    /// </summary>
}