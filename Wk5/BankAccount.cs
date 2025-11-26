namespace Wk4.Wk5
{
    // BankAccount class to manage bank account operations
    public class BankAccount
    {
        // Private fields
        private string accountNumber;
        private double balance;

        // Public property: AccountNumber with only get accessor
        // Value is set through constructor
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Public property: Balance with private set and validation
        // Doesn't allow negative or 0 values
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Error: Balance cannot be negative or zero.");
                }
            }
        }

        // Constructor to initialize account number and initial balance
        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            // Use property setter to validate initial balance
            Balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            // Validate deposit amount
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
            }
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            // Validate withdrawal amount
            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive.");
            }
            else if (amount > balance)
            {
                Console.WriteLine($"Error: Insufficient funds. Current balance: ${balance}");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrew ${amount}. New balance: ${balance}");
            }
        }
    }
}
