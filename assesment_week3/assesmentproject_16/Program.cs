namespace assesmentproject_16;

class Program
{
    static void Main(string[] args)
    {
        int[] data = { 9, 2, 7, 2 };
        
        Array.Sort(data);
        Console.WriteLine("Sorted array: " + string.Join(", ", data));
    }
}
