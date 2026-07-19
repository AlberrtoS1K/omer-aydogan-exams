namespace assesmentproject_20;

class Program
{
    static void Main(string[] args)
    {
        List<double> readings = new List<double> { 1.1, 2.2, 3.3 };
        IEnumerable<double> enumerableReadings = readings;
        double sum = 0;


        foreach (double reading in enumerableReadings)
        {
           sum += reading;
        }
        Console.WriteLine($"{sum:F2}");
    }
}
