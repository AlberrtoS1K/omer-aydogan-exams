namespace assesmentproject_5;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.Owner = "OMER MURAT AYDOGAN ";
        account.Deposit(1000);
        account.Withdraw(500);
        Console.WriteLine(account.Balance);
        Console.WriteLine($"Account: {account.Owner} — Balance: {account.Balance:C}");
    }
}

class BankAccount
{
    public string? Owner;

     private decimal balance; 


    public void Deposit(decimal amount)
    {
       balance += amount;
    }
    public void Withdraw(decimal amount)
    { if (balance >= amount)
    {
       balance -= amount;
    }
    
    }
    public decimal Balance
    {
        get { return balance; }
        
    }
    
    }

