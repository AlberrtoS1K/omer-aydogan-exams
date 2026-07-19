namespace assesmentproject_7;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine( "Enter your birthday year" )
      ;

      int birthYear = int.Parse(Console.ReadLine());

      int age = 2026 - birthYear
      ;
      Console.WriteLine ("Your approximate age is " + age )
      ;

    }
}
