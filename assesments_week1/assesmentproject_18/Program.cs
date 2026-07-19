namespace assesmentproject_18;

class Program
{
    static void Main(string[] args)
    {
            int x = 1
            ;
            bool result = (x != 0) && (10 / x > 1)
            ;
            Console.WriteLine($"Result : {result}")
            ;

            // Left side is false, so right side is not evaluated due to short-circuit && operator.

    }
}
