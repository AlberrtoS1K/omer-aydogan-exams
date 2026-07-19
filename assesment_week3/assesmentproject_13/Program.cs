namespace assesmentproject_13;

class Program
{
    static void Main(string[] args)
    {
        string messy = "INFOTECH Academy";
        string cleaned = messy.Trim().ToUpper();
        Console.WriteLine($"Cleaned string: {cleaned}");
        bool hasAcademy = cleaned.Contains("ACADEMY");
        Console.WriteLine($"Contains 'ACADEMY': {hasAcademy}");

    }
}
