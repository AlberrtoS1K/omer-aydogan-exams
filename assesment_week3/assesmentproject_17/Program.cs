namespace assesmentproject_17;

class Program
{
    static void Main(string[] args)
    {
       char[] letters = { 'z', 'a', 'm', 'k' };
       Array.Sort(letters);
       Console.WriteLine("Sorted letters in ascending order:");
       Console.WriteLine(String.Join(", ", letters));
       Array.Reverse(letters);
       Console.WriteLine("Sorted letters in descending order:");
       Console.WriteLine(String.Join(", ", letters));
    }
}
