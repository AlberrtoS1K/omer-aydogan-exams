namespace assesmentproject_11;

class Program
{
    static void Main(string[] args)
    {
        int a = 14
        ;
        int b = 6
        ;

        int intResult = a / b 
        ;

        double doubleResult = (double) a / b
        ;

        Console.WriteLine ("Integer Devision " + intResult)
        ;

        Console.WriteLine ( "float-pointing Devision " + doubleResult)
        ;

        // int / int -> drops decimal part
        // casting to double -> keeps decimal part
    }
}
