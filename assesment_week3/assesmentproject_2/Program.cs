namespace assesmentproject_2;

class Program
{
    static void Main(string[] args)
    {
       for (int i = 1; i <= 6; i++) 
        {
            
            int otherNumber = 7 - i;
            int result = i * otherNumber;
            Console.WriteLine($"{i} x {otherNumber} = {result}");
        }
        
    }
}
