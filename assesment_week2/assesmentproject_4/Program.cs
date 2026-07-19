namespace assesmentproject_4;

class Program
{
    static void Main(string[] args)
    {
       decimal IndividualPrice = 249.97m;
       int IndividualQuantity = 2;
       decimal vatRate = 20m;


         decimal totalPrice = IndividualPrice * IndividualQuantity;
         decimal vatAmount = totalPrice * (vatRate / 100);
         decimal total = totalPrice + vatAmount;
         
         Console.WriteLine($"Total Price: {totalPrice:C}");
         Console.WriteLine($"VAT Amount: {vatAmount:C}");
         Console.WriteLine($"Total Amount (including VAT): {total:C}");
    }
}
