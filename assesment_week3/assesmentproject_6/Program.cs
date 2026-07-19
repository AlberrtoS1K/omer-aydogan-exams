namespace assesmentproject_6;

class Program
{
    static void Main(string[] args)
    {
       List<string> cities = new List<string>();
       cities.Add("New York");
       cities.Add("Los Angeles");
       cities.Add("Chicago");

       Console.WriteLine($"Overall: {cities.Count} cities");
       foreach (string city in cities)
       {
           Console.WriteLine($"- {city}");
       }
    }
}
