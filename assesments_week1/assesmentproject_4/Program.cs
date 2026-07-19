namespace assesmentproject_4;

class Program
{
    static void Main(string[] args)
    {
       decimal unitPrice = 400
       ; 
        int Quantity = 20
        ;

       decimal taxRate = 0.20m;


        decimal subtotal= unitPrice*Quantity
        ;
        decimal tax = subtotal *taxRate
        ;
        decimal total = subtotal + tax
        ;

        Console.WriteLine ($"Subtotal : {subtotal:C}")
        ;
        Console.WriteLine ($"Tax : {tax:C}")
        ;
        Console.WriteLine ($"Total : {total:C}")
        ;


       


       Console.WriteLine ($"{total:C}"); 
    }
}
