namespace _8RawData
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
                var data = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];

                double engineSpeed = double.Parse(data[1]);
                double enginePower = double.Parse(data[2]);
                double cargoWeight = double.Parse(data[3]);
                string cargoType = data[4];
                double tire1Pressure = double.Parse(data[5]);
                double tire1Age = double.Parse(data[6]);
                double tire2Pressure = double.Parse(data[7]);
                double tire2Age = double.Parse(data[8]);
                double tire3Pressure = double.Parse(data[9]);
                double tire3Age = double.Parse(data[10]);
                double tire4Pressure = double.Parse(data[11]);
                double tire4Age = double.Parse(data[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire tireOne = new Tire(tire1Age, tire1Pressure);
                Tire tireTwo = new Tire(tire2Age, tire2Pressure);
                Tire tireThree = new Tire(tire3Age, tire3Pressure);
                Tire tireFour = new Tire(tire4Age, tire4Pressure);

                Car car = new Car(model, engine, cargo, tireOne, tireTwo, tireThree, tireFour);
                cars.Add(car);
            }

            string cargoTypeCommand = Console.ReadLine();

            if (cargoTypeCommand == "fragile")
            {
                var resultCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1))
                    .ToList();

                foreach (var car in resultCars)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else if (cargoTypeCommand == "flamable")
            {
                var resultCars = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).ToList();

                foreach (var car in resultCars)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}