namespace assesmentproject_19;

class Program
{
    static void Main(string[] args)
    {
       int grade = Convert.ToInt32(Console.ReadLine())
       ;
       if (grade < 50)
        {
            Console.WriteLine("Didn't pass from the section")
            ;
        }
        else if (grade <= 69)
        {
            Console.WriteLine("Passed with medium-grade")
            ;
        }
        else if (grade <= 84)
        {
            Console.WriteLine("Passed with well grade ")
            ;
        }
        else
        {
            Console.WriteLine(" Passed with well grade with successfully")
            ;

        }
    }
}
