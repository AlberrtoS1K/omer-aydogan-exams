namespace assesmentproject_12;

class Program
{
    static void Main(string[] args)
    {
      Console.Write(" Enter a Integer Number: ");
      
      string input = Console.ReadLine();
      if (int.TryParse(input, out int number))
      {
        if (number % 2 == 0)
        {
          Console.WriteLine($"{number} is an Even Number.");
        }
        else
        {
          Console.WriteLine($"{number} is an Odd Number.");
        }
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
      }
    }
}
