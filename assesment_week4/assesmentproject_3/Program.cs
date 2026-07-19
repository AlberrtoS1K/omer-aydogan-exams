namespace assesmentproject_3;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("  OMER MURAT   ", "AYDOGAN   ");

        student.Age = 21;

        Console.WriteLine($"Öğrenci: {student.Name} {student.Surname} — Yaş: {student.Age}");
    }
}

class Student
{
    private string name = "";
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value.Trim().ToUpper(); }
    }

    public string Surname { get; set; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 150)
            {
                age = value;
            }
        }
    }

    public Student(string name, string surname)
    {
        Name = name;
        Surname = char.ToUpper(surname[0]) + surname.Substring(1).ToLower();
    }
}