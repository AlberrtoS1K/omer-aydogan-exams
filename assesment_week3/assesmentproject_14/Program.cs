namespace assesmentproject_14;

class Program
{
    static void Main(string[] args)
    {
        string tags = "csharp;dotnet;web";
        string [] parts = tags.Split(';');
        Console.WriteLine($"Tag number {parts.Length}");
        Console.WriteLine($"Last tag: {parts[parts.Length - 1]}");
    }
}
