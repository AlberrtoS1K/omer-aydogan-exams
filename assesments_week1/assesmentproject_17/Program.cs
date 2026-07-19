namespace assesmentproject_17;

class Program
{
    static void Main(string[] args)
    {
       int grade = Convert.ToInt32(Console.ReadLine())
       ;
       bool isValid = grade >= 0 && grade <= 100 
       ;
       if (isValid)
        {
            Console.WriteLine("Mark valid")
            ;
        }
        
            else
            {
                Console.WriteLine("Mark not valid")
                ;

            }
        }
    }

