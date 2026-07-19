namespace assesmentproject_2;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();
        
        product1.productName = "Laptop";
        
        product1.Price = 999.99; // This line will cause a compilation error because 'Price' is not defined in the Product class.




        Console.WriteLine("Product Name: " + product1.productName);
        Console.WriteLine("Product Price: " + product1.Price);

    }
}
class Product
{
    public string? productName;
    private double productPrice;
    
    public double Price
    {
        get { return productPrice; }
        set
        {
            if (value >= 0)
            {
                productPrice =value;
            }
            
        }
    }
}
