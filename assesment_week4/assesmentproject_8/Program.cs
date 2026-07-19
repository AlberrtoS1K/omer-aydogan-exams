
using System.Reflection.Metadata.Ecma335;

namespace assesmentproject_8;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "OMER MURAT AYDOGAN";
        Console.WriteLine(person.GetInfo());
    }
}

class Person
{
    public string? Name;
    public string GetInfo()
    {
       return $"{Name} - Role: Personal";
    }
    }
     
     
