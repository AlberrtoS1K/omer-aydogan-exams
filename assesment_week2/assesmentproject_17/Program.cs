namespace assesmentproject_17;

class Program
{
    static void Main(string[] args)
    {
        int grade = 100;
        bool isValid = grade >= 0 && grade <= 100;
         if (isValid)
        {
            Console.WriteLine("The grade is valid.");
        }
        else
        {
            Console.WriteLine("The grade is invalid.");
        }    
    }
}

