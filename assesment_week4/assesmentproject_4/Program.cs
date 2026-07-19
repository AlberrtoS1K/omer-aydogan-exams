namespace assesmentproject_4;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Omer Murat";
        Student student2 = new Student();
        student2.Name = "Ahmet Faruk";
        student1.Work();
        student2.Work();
        Console.ReadLine();
    }
}
class Student
{
    public string? Name { get; set; }
    public void Work()
    {
        Console.WriteLine($"{Name} is working for MCSD");
    }
}