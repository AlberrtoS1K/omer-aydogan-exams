namespace assesmentproject_6;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 100;
        double expendedNumber = number1;

        double DecimalNumber = 10.5;
        int TruntucatedNumber = (int)DecimalNumber;

        Console.WriteLine($"The expended number is: {expendedNumber}");
        Console.WriteLine($"The truntucated number is: {TruntucatedNumber}");
        Console.WriteLine("Note: The decimal part is truntaced, not rounded.");
        
    }
}
