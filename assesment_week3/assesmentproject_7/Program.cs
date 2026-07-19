namespace assesmentproject_7;

class Program
{
    static void Main(string[] args)
    {
        List<int> ids = new List<int> { 101, 102, 103, 104 };
        ids.Remove(102);
        Console.WriteLine($"Remaining IDs: {ids.Count}");
        Console.WriteLine("IDs: " + string.Join(", ", ids));

    }
}
