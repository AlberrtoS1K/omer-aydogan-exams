namespace assesmentproject_5;

class Program
{
    static void Main(string[] args)
    {
        double [] prices = { 10.5, 20.0, 15.75, 30.25 };
        double maxPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > maxPrice)
            {
                maxPrice = prices[i];
            }
        }

        Console.WriteLine("The highest price is: " + maxPrice);
    }
}
