namespace assesmentproject_13;

class Program
{
    static void Main(string[] args)
    {
        int totalEggs = 233
        ;
        int eggPerBox = 62
        ;
        int fullBoxes = totalEggs / eggPerBox
        ;
        int remainingEggs = totalEggs % eggPerBox
        ;
        double percentage = (double)remainingEggs / totalEggs * 100 
        ;
            Console.WriteLine ($"Fulled Box : {fullBoxes}")
            ;
            Console.WriteLine ($"Remaining Eggs : {remainingEggs}")
            ;
            Console.WriteLine ($"Remaining Eggs Percentage : {percentage:F2}")
            ;

    }
}
