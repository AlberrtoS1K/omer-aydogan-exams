namespace assesmentproject_9;

class Program
{
    static void Main(string[] args)
    {
        SortedList<string, int> students
          = new SortedList<string, int>();
         students.Add("John", 90);
         students.Add("Alice", 85);
         students.Add("Bob", 95);
         foreach  (var student in students)
         {
             Console.WriteLine($"Name: {student.Key}, Score: {student.Value}");
         }  
    }
}
