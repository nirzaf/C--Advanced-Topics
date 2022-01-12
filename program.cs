// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");


//create a class for vehicle
public class Vehicle
{
    public int VehicleId { get; set; }
    public string VehicleName { get; set; }
    public string VehicleType { get; set; }
    public string VehicleColor { get; set; }
    public int VehicleYear { get; set; }
    public int VehiclePrice { get; set; }

    public void Run()
    {
        Console.WriteLine("Vehicle is running");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle is stopped");
    }
}


//create a class for customer
public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerAddress { get; set; }
    public string CustomerPhone { get; set; }
    public string CustomerEmail { get; set; }
}

public class Car : Vehicle
{
    
}


public class Motorcycle : Vehicle
{
    Car car = new Vehicle();
    Car.Run();

}




