namespace assesmentproject_7;

class Program
{
    static void Main(string[] args)
    {
        
       List<Course> courses = new List<Course>();
       courses.Add(new Course("Math", "MATH101", 2));
       courses.Add(new Course("English", "ENG101", 3));
       courses.Add(new Course("Science", "SCI101", 4));

         int totalHours = 0;
    
    foreach (var course in courses)
    {
        totalHours += course.Credits;

    }   
        Console.WriteLine($"Total Time:  {totalHours} hours");

       foreach (var course in courses)
       {
            Console.WriteLine($"Course Name: {course.Name}, Course Code: {course.Code}, Credits: {course.Credits}");
       }
    }
}

class Course
{
   public string Name;
   public string Code;
   public int Credits;

   public Course (string name, string code, int credits)
    {
        Name = name;
        Code = code;
        Credits = credits;

      

    }

    
        
    
    
}
