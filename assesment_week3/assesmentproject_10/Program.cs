namespace assesmentproject_10;

class Program
{
    static void RepeatPrint(string label, int times){
        for (int i = 1; i <= times; i++)
        {
            Console.WriteLine($"{label} ({i})");
        }
    }

    static void Main(string[] args)
    {
        RepeatPrint("Sentence", 3);
    }
}
