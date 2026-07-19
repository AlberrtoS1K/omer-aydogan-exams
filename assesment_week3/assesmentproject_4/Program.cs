namespace assesmentproject_4;

class Program
{
    static void Main(string[] args)
    {
        double[] prices = { 12.5, 8.0, 15.75, 3.25 };
        double sum = 0;
        foreach (var n in prices)
        {
            sum += n;
        }
        double average = sum / prices.Length;
        Console.WriteLine($"Average price: {average:F2}");
    }
}
