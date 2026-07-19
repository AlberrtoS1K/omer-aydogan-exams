namespace assesmentproject_8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your birth year: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            int age = 2026 - number;
            Console.WriteLine($"Approximate age: {age}");

        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid year.");
        }   
    }
}
