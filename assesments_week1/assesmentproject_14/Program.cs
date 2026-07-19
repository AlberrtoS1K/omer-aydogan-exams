namespace assesmentproject_14;

class Program
{
    static void Main(string[] args)
    {
        int  totalMinutes = Convert.ToInt32(Console.ReadLine())
        ;
        int hours = totalMinutes / 60
        ;
        int remainingMinutes = totalMinutes % 60
        ;

        Console.WriteLine($"{hours} hour {remainingMinutes} minutes")   
        ;

    }
}
