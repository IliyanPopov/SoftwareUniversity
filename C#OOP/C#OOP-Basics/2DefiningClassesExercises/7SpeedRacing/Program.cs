namespace _7SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumptionPerKilometer = double.Parse(data[2]);

                Car car = new Car
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKilometer = fuelConsumptionPerKilometer,
                    DistanceTraveled = 0
                };
                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                var data = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string model = data[1];
                double amountOfKilometres = double.Parse(data[2]);

                var car = cars.FirstOrDefault(x => x.Model == model);
                car.TravelDistance(amountOfKilometres);

                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}