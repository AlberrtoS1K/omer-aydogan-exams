using System.Reflection;
using System.Security.Cryptography;

namespace supportassesmentproject_3;

class Program
{
    static void Main(string[] args)
    {
        string name = "Alberto"
         ;
        byte age = 20
        ;
        string city= "London"
        ;
        bool isLightOn = true;

        ;
        Console.WriteLine ($" name {name} age {age} city {city} {(isLightOn ? "Open" : "Closed" )} ");


    }
}
