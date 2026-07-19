namespace assesmentproject_1;

class Program
{
    static void Main(string[] args)
    {
      Book book = new Book();

      book.Title = "The Great Gatsby";
      book.Author = "F. Scott Fitzgerald";
      Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
    }
}
    class Book
    {
       public string? Title { get; set; }
       public string? Author { get; set; }
    }
