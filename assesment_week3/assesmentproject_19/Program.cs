namespace assesmentproject_19;

class Program
{
    static string NormalizeCourseCode(string code)
    {
        return code.Trim().ToUpper();
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"mcsd - 101");
    }
}
