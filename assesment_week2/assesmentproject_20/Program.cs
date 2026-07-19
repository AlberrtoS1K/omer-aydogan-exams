namespace assesmentproject_20;

class Program
{
    static void Main(string[] args)
    {
        decimal balance = 1000.00m; 
        
        Console.WriteLine("Initial Amount: " + balance);
        string? input = Console.ReadLine();
        if (decimal.TryParse(input, out decimal amount))
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive value.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds. Transaction cannot be completed.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Transaction successful. New balance: " + balance);
            }

        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid decimal number.");
        }
        
    }
}
