namespace assesmentproject_15;

class Program
{
    static void Main(string[] args)
    {
       int age = Convert.ToInt32(Console.ReadLine())
       ;
       bool isCitizen = Convert.ToBoolean(Console.ReadLine())
       ;
       
       bool canVote = age >= 18 && isCitizen;

       if (canVote)
       
        {
            Console.WriteLine("Yes Available for Vote")
            ;

        }
        else
        {
            Console.WriteLine ("No, Not Available for Vote ")
            ;
            
        }

    }
}
