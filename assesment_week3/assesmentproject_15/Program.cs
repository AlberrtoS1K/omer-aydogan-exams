namespace assesmentproject_15;

class Program
{
    static void Main(string[] args)
    {
        string template = "Merhaba NAME, hoş geldin";
        template = template.Replace("NAME", "OMER MURAT ");
        Console.WriteLine(template);
    }
}
