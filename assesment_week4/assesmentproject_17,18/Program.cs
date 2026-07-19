using System.Formats.Asn1;
using System.Runtime.InteropServices;

namespace assesmentproject_17;

class Program
{
    static void Main(string[] args)
    {

         List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle {Width = 3, Height = 9});
        shapes.Add(new Circle { Radius = 2});
        shapes.Add(new Rectangle { Width = 4, Height = 6 });

        double totalArea = 0;

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.Label()} - Area: {shape.Area()}");

            totalArea += shape.Area();
        }
            Console.WriteLine($"Total Area {totalArea}");
        
         
        Rectangle rectangle = new Rectangle();

        rectangle.Width = 3.4;
        rectangle.Height = 13.2;

        Circle circle = new Circle();


        circle.Radius = 21;

        Console.WriteLine(rectangle.Width);
        Console.WriteLine(rectangle.Label());
        Console.WriteLine(circle.Label());
        Console.WriteLine(rectangle.Area());
        Console.WriteLine(circle.Area());
    }
}
abstract class Shape
{
    public string Label()
    {
        return "It's a shape";
    }
    public abstract double Area();



}
class Rectangle : Shape
{

    public double Width { get; set; }

    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }

}

class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}