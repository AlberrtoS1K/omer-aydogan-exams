namespace assesmentproject_14;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write (" Enter a minute value: ");
        int Totalminutes = Convert.ToInt32(Console.ReadLine());

        int hours = Totalminutes /  60;
        int minutes = Totalminutes % 60;

        Console.WriteLine($"The value in hours and minutes is: {hours} hours and {minutes} minutes");

    }
}
