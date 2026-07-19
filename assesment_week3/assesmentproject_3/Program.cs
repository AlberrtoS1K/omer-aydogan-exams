namespace assesmentproject_3;

class Program
{
    static void Main(string[] args)
    {
        int[] temperatures = { 18, 22, 19, 25 };

        Console.WriteLine("longest " + temperatures.Length);
        Console.WriteLine("First " + temperatures[0]);
        Console.WriteLine("Last " + temperatures[temperatures.Length - 1]);
    }
}
