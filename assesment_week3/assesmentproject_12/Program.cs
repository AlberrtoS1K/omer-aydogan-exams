namespace assesmentproject_12;

class Program
{
    static string Describe(int value)
    {
        return $"The odd is {value}.";
    }
    static string Describe(double value)
    {
        return $"The numberous is {value:F2}.";
    }
    static void Main(string[]args)
    {
        Console.WriteLine($"int: {Describe(5)}");
        Console.WriteLine($"double: {Describe(3.14)}");
    }
}
