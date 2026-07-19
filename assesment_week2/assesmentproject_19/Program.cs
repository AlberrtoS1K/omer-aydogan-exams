namespace assesmentproject_19;

class Program
{
    static void Main(string[] args)
    {
        int grade = 100;
        if (grade >= 90)
        {
            Console.WriteLine("Passed with success");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Passed with distinction");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Passed with credit");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Passed with pass");
        }
        else
        {
            Console.WriteLine("Failed");
        }


    }
}
