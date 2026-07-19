using System.Diagnostics;

namespace assesmentproject_16;

class Program
{
    static void Main(string[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine())
        ;
        bool isStudent = Convert.ToBoolean(Console.ReadLine())
        ;
        
            bool discount = isStudent || age >= 65;
        if (discount)
        {
            Console.WriteLine("Discount will be applied")
        ;
            }
            else
        {
            Console.WriteLine ("Discount will not be applied")
            ;

        }
    }
}
