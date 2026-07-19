using System.Runtime.ConstrainedExecution;

namespace assesmentproject_9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter product price")
        ;
        string input = Console.ReadLine()
        ;  
        decimal price;

if (decimal.TryParse(input, out price))
{
    decimal finalPrice = price - 10m;

    if (finalPrice < 0)
    {
        finalPrice = 0;
    }

    Console.WriteLine(finalPrice.ToString("C"));
}
else
{
    Console.WriteLine("Invalid price");
}

    }
}
