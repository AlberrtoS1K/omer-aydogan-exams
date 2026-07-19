namespace assesmentproject_8;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine (" enter your birtday year")
       ;
       string input = Console.ReadLine();
       
       int birthYear;

       if (int.TryParse(input, out birthYear))

        {
            int age = 2026 - birthYear
            ;
            Console.WriteLine ("Your approximate age is" + age)
            ;

        }
        else
        {
            Console.WriteLine ("Invalid Year")
            ;

        }
    }
}
