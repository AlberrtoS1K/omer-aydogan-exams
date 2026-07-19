namespace assesmentproject_7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Birth Year: ");
        string input = Console.ReadLine();
        int BirthYear = int.Parse(input);
        int age = 2026 - BirthYear;
        Console.WriteLine($"Approximate age is: {age}");
    }
}
