namespace assesmentproject_8;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, decimal> products = new Dictionary<string, decimal>()
        {
            { "Apple", 0.5m },
            { "Banana", 0.3m },
            { "Orange", 0.7m },
            { "Grapes", 1.2m }
            
        };
        string code = "Apple";
        if (products.ContainsKey(code))
        {
            decimal price = products[code];
            Console.WriteLine($"The price of {code} is {price:C}");
        }
        else
        {
            Console.WriteLine($"Product with code '{code}' not found.");
        }
        
    }
}
