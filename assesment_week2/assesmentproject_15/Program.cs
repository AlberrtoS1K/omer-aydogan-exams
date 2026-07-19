
namespace assesmentproject_15;

class Program
{
    static void Main(string[] args)
    {
        int age = 30;
        bool isCiziten = true;
        bool CanVote = age >= 18 && isCiziten;
        
        
        Console.WriteLine($"You can use vote: {(CanVote? "yes" : "no")}"); 
    }
}
