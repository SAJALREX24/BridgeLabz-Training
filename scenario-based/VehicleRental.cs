
/*

 Vehicle Rental Application
● Concepts: Vehicle, Bike, Car, Truck, Customer.
● Access Modifiers: protected fields.
● Interface: IRentable with CalculateRent(int days).

*/

using System;

// Interface defining rent calculation 
interface IRentable
{
    
    double CalculateRent(int totalDays);
}

// Base class 
class VehicleBase
{
   
    protected double dailyRate;
    public string VehicleModel;
    public virtual void ShowInfo()
    {
        Console.WriteLine("Model: " + VehicleModel);
    }
}

// Bike rental class
class BikeRental : VehicleBase, IRentable
{
   
    public BikeRental()
    {
        dailyRate = 300;
    }

    // Calculates bike rent
    public double CalculateRent(int totalDays)
    {
        return dailyRate * totalDays;
    }
}

// Car rental class
class CarRental : VehicleBase, IRentable
{
    // Constructor sets daily rent for car
    public CarRental()
    {
        dailyRate = 800;
    }

    // Calculates car rent
    public double CalculateRent(int totalDays)
    {
        return dailyRate * totalDays;
    }
}

// Truck rental class
class TruckRental : VehicleBase, IRentable
{
    // Constructor sets daily rent for truck
    public TruckRental()
    {
        dailyRate = 1500;
    }

    // Calculates truck rent
    public double CalculateRent(int totalDays)
    {
        return dailyRate * totalDays;
    }
}


class CustomerInfo
{
    
    public string CustomerName;
}

// Program class
class RentalProgram
{
    static void Main()
    {
        // Creating customer
        CustomerInfo customer = new CustomerInfo();
        customer.CustomerName = "Sahil";

       
        VehicleBase bike = new BikeRental { VehicleModel = "Yamaha" };
        VehicleBase car = new CarRental { VehicleModel = "Honda City" };
        VehicleBase truck = new TruckRental { VehicleModel = "Tata Truck" };

        // Display customer information
        Console.WriteLine("Customer: " + customer.CustomerName);
        Console.WriteLine();

        
        Console.WriteLine("Bike Rent (3 days): " + ((IRentable)bike).CalculateRent(3));
        Console.WriteLine("Car Rent (3 days): " + ((IRentable)car).CalculateRent(3));
        Console.WriteLine("Truck Rent (3 days): " + ((IRentable)truck).CalculateRent(3));
    }
}
