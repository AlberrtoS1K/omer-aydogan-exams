    namespace assesmentproject_12;

    class Program
    {
        static void Main(string[] args)
        {
            string? input = Console.ReadLine()
            ;
            
            int number;
            bool isValid = int.TryParse(input, out number)
            ;
            if (isValid)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine ("Even")
                    ;
                }
                else
                    {
                        Console.WriteLine ("Odd")
                        ;
                        
                    }
                }
            }
        }


