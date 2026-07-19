using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace assesmentproject_10;

class Program
{
    static void Main(string[] args)
    {







        Manager manager = new Manager();

        manager.fullName = "OMER MURAT AYDOGAN";
        manager.baseSalary = 39000;
        manager.Prime = 3500;
        // Console.WriteLine($"Manager: {manager.fullName} - {manager.CalculateSalary()}£");

        Developer developer = new Developer();

        developer.fullName = "AHMET YILMAZ";
        developer.baseSalary = 15000;
        developer.Level = "Junior";

        // Console.WriteLine($"Game Developer: {developer.fullName} - {developer.CalculateSalary()}£");
        Developer developer1 = new Developer();

        developer1.fullName = "ZEYNEP TOPCU";
        developer1.baseSalary = 21000;
        developer1.Level = "Senior";


        // Console.WriteLine($"C# Developer: {developer1.fullName} - {developer1.CalculateSalary()}£");

        // int total = 0;

        List<Employee> employees = new List<Employee>();

        employees.Add(manager);
        employees.Add(developer);
        employees.Add(developer1);


        foreach (Employee employee in employees)
        {
            // Console.WriteLine($"{employee.fullName} {employee.CalculateSalary:()}");
            // total += employee.CalculateSalary();
           if (employee is Manager)
           {
                Manager m = (Manager) employee; 

                Console.WriteLine($"{m.fullName}- Manager, Prime: {m.Prime:N0}");
                
                


           }
           else if (employee is Developer)
                {
                    Developer d = (Developer) employee;

                        Console.WriteLine($"{d.fullName}- Developer, Level:{d.Level}");
                
                }
               
                
            

        }
            //  Console.WriteLine($"Total {total}£");



    }



}

class Employee
{
    public string? fullName { get; set; }
    public int baseSalary { get; set; }

    public virtual int CalculateSalary()
    {
        return baseSalary;

    }






}

class Manager : Employee
{

    public int Prime { get; set; }


    public override int CalculateSalary()
    {
        return baseSalary + Prime;
    }

}

class Developer : Employee
{
    public string? Level { get; set; }
    public override int CalculateSalary()
    {
        if (Level == "Senior")
        {
            return baseSalary + 5000;
        }

        return baseSalary;

    }




}