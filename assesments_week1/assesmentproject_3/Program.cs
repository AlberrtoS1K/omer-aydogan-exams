using System.Diagnostics;

namespace assesmentproject_3;

class Program
{
    static void Main(string[] args)
    {
       
       double  temperature = 23.5;
       bool isWindowOpen = true;

        char unit = 'C';


        Console.WriteLine ($"  {temperature} {(isWindowOpen ? "Yes" : " No")} {unit}  " );

        

    }
}
