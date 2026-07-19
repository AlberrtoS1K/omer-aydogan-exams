namespace assesmentproject_13;

class Program
{
    static void Main(string[] args)
    {
            int eggs = 23;
            int boxCapacity = 6;

            int fullBoxes = eggs / boxCapacity;
            int remainingEggs = eggs % boxCapacity;

            Console.WriteLine($"Full boxes: {fullBoxes}");
            Console.WriteLine($"Remaining eggs: {remainingEggs}");
    }
}
