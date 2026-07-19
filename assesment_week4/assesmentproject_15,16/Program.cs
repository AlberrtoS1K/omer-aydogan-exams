using System.ComponentModel;

namespace assesmentproject_15;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        Car car = new Car();

        vehicles.Add(car);

        Motorcycle moto = new Motorcycle();

        moto.Brand = "Yamaha MT-09";
        moto.modelYear = 2019;

        vehicles.Add(moto);

        car.Brand = "Mercedes Benz C200-D";
        car.modelYear = 2020;

        foreach (Vehicle item in vehicles)
        {
            //  Console.WriteLine($"Brand: {item.Brand}, Year {item.modelYear}, Type: {item.Description()}");
            Console.WriteLine(item);
        }

    }
}
class Vehicle
{

    public virtual string Description()
    {
        return "";
    }
    public string? Brand { get; set; }

    public int modelYear { get; set; }

    public override string ToString()
    {
        return $"{Brand} ({modelYear})";
    }
    
    
    

    
}

class Car : Vehicle
{


    public override string Description()
    {
        return "Car";
    }

}

class Motorcycle : Vehicle
{
    public override string Description()
    {
        return "Motorcycle";
    }
}
