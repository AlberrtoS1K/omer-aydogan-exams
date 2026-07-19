namespace assesmentproject_11;

class Program
{
    static int TotalStock(int boxCount, int perBox)
    {
       return boxCount * perBox;
    }
    static void Main(string[] args)
    {
        int result = TotalStock(5, 10);
        Console.WriteLine($"Total stock: {result}");
    }
}
