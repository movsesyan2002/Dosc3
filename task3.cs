// Task 3: Bank Account
// Task: Create a BankAccount class with:
// AccountNumber, HolderName, Balance.
// Methods Deposit(amount) and Withdraw(amount), ensuring balance never goes negative.
// In Main(), allow the user to create an account and perform deposits/withdrawals.
// // Prevent withdrawal if insufficient funds and show an error message.

class BankAccount 
{
    public int AccountNumber; 
    public string HolderName; 
    public int Balance;

    public BankAccount(int AccountNumber, string HolderName,int Balance) {
        this.AccountNumber = AccountNumber;
        this.HolderName = HolderName;
        this.Balance = Balance;
    }

    public void Deposit(int amount) 
    {
        Balance += amount;
    }

    public void Withdraw(int amount) 
    {

        if (amount < 0) 
        {
            Console.WriteLine("invalid argument");
            return;
        }

        else if (Balance - amount < 0)
        {
            Console.WriteLine("Insufficient funds");
            return;
        }
        Balance -= amount;
    }

}

class Program{
    static void Main(string[] args) 
    {
        Random rand = new Random();
        Console.WriteLine("Enter name");
        string? name = Console.ReadLine();

        BankAccount customer = new BankAccount(rand.Next(1000,10000),name,0);
        customer.Deposit(120000);
        customer.Withdraw(119000);
        customer.Withdraw(2000);
        Console.WriteLine($"Amount is {customer.Balance}");

    }
}

