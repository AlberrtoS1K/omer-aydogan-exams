namespace assesmentproject_9;

class Program
{
    static void Main(string[] args)
    {
      
        Person person = new Person();
        person.Name = "OMER MURAT AYDOGAN";
        Console.WriteLine(person.GetInfo());
        StudentPerson  studentperson = new StudentPerson();
        studentperson.Name = "OMADO";
        studentperson.studentNumber = "43";

        Console.WriteLine(studentperson.GetInfo());
        
        



        
    
}

class Person

{
    public string? Name;
    public virtual string GetInfo()
    {
       return $"{Name} - Role: Personal";
    }

}

class StudentPerson : Person
{
    public string? studentNumber;
    
    public override string GetInfo()
    {
        return $"{Name} - Student Number: {studentNumber} - Role: Student";
    }
   
    

    
}


}