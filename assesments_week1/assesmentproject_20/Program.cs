namespace assesmentproject_20;

class Program
{
    static void Main(string[] args)
        
    {   
        decimal balance = 250;

        decimal  amount;

        decimal.TryParse(Console.ReadLine(), out amount)
        ;
        if (amount <= 0)
        {
            Console.WriteLine(" Unvalid amount ");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficent credit")
            ;
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"New amount : {balance:C}  ");
        }
    }
}
