namespace assesmentproject_9;

class Program
{
    static void Main(string[] args)
    {
       Console.Write(" Enter a Price For the Product: ");
       string? input = Console.ReadLine();
       
       if (decimal.TryParse(input, out decimal price))
        {
            decimal FinalPrice = Math.Max(price - (price * 0.10m), 0);
            
            Console.WriteLine($"The Final Price after 10% discount is: {FinalPrice:C}");

        }   
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid decimal number for the price.");
        }
    }
}
