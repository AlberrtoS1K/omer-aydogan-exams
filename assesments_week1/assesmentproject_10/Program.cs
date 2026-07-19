namespace assesmentproject_10;

class Program
{
    static void Main(string[] args)
    {
        string input =Console.ReadLine() ?? "0"
        ;
        int number = int.Parse(input);
        
        int result = number *2 
        ;
        Console.WriteLine("Double " + result)
        ;

    }
}
