using System;

public class Startup
{
    public static void Main()
    {
        var carData = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        double fuelQuantityCar = double.Parse(carData[1]);
        double litersPerKmCar = double.Parse(carData[2]);
        double tankCapacityCar = double.Parse(carData[3]);

        Car car = new Car(fuelQuantityCar, litersPerKmCar, tankCapacityCar);

        var truckData = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        double fuelQuantityTruck = double.Parse(truckData[1]);
        double litersPerKmTruck = double.Parse(truckData[2]);
        double tankCapacityTruck = double.Parse(truckData[3]);

        Truck truck = new Truck(fuelQuantityTruck, litersPerKmTruck, tankCapacityTruck);

        var busData = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        double fuelQuantityBus = double.Parse(busData[1]);
        double litersPerKmBus = double.Parse(busData[2]);
        double tankCapacityBus = double.Parse(busData[3]);

        Bus bus = new Bus(fuelQuantityBus, litersPerKmBus, tankCapacityBus);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var commandData = Console.ReadLine().ToLower().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (commandData[1] == "car")
            {
                if (commandData[0] == "drive")
                {
                    double distance = double.Parse(commandData[2]);
                    try
                    {
                        car.Drive(distance);
                        Console.WriteLine($"Car travelled {distance} km");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (commandData[0] == "refuel")
                {
                    double volumeAmount = double.Parse(commandData[2]);
                    try
                    {
                        car.Refuel(volumeAmount);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            else if (commandData[1] == "truck")
            {
                if (commandData[0] == "drive")
                {
                    double distance = double.Parse(commandData[2]);
                    try
                    {
                        truck.Drive(distance);
                        Console.WriteLine($"Truck travelled {distance} km");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (commandData[0] == "refuel")
                {
                    double volumeAmount = double.Parse(commandData[2]);
                    try
                    {
                        truck.Refuel(volumeAmount);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (commandData[1] == "bus")
            {
                if (commandData[0] == "drive")
                {
                    double distance = double.Parse(commandData[2]);
                    try
                    {
                        bus.HasPeopleInside = true;
                        bus.Drive(distance);
                        Console.WriteLine($"Bus travelled {distance} km");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (commandData[0] == "driveempty")
                {
                    double distance = double.Parse(commandData[2]);
                    try
                    {
                        bus.HasPeopleInside = false;
                        bus.Drive(distance);
                        Console.WriteLine($"Bus travelled {distance} km");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (commandData[0] == "refuel")
                {
                    double volumeAmount = double.Parse(commandData[2]);
                    try
                    {
                        bus.Refuel(volumeAmount);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

        }

        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
        Console.WriteLine(bus.ToString());
    }
}