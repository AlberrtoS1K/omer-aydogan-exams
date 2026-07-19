global using System;
namespace assesmentproject_16;

class Program
{
    static void Main(string[] args)
    {
     
        bool isStudent = true;
        int age = 23;
        bool discount = isStudent || age >= 65;

        if (discount)
        {
            Console.WriteLine ("Discount is applied");
        }
        else
        {
            Console.WriteLine ("Discount is not applied");
            
        }
    }
}
