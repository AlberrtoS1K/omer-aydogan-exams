namespace assesmentproject_6;

class Program
{
    static void Main(string[] args)
    {
       Course course = new Course(
        "CS101", 
        "Introduction to Computer Science"
        , 40);

       course.PrintSummary();
       Console.ReadLine();
    }
}

class Course
{
    public string CourseCode;
    public string? Title;
    public int? Duration; 

    public Course (string courseCode, string? Title, int? Duration)
    {
        this.CourseCode = courseCode;
        this.Title = Title;
        this.Duration = Duration;
        
    }
    public void PrintSummary()
    {
       Console.WriteLine($"{CourseCode} - {Title} ({Duration} hours)");
    }
}
