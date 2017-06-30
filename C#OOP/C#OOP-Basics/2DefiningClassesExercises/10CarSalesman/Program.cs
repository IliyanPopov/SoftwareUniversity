namespace _10CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                int power = int.Parse(data[1]);
                int displacement;
                string efficiency;

                if (data.Length == 4)
                {
                    displacement = int.Parse(data[2]);
                    efficiency = data[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }

                else if (data.Length == 3 && int.TryParse(data[2], out displacement))
                {
                    Engine engine = new Engine(model, power, displacement);
                    engines.Add(engine);
                }
                else if (data.Length == 3 && !int.TryParse(data[2], out displacement))
                {
                    efficiency = data[2];
                    Engine engine = new Engine(model, power, efficiency: efficiency);
                    engines.Add(engine);
                }
                else
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                var data = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string carModel = data[0];
                string engineModel = data[1];
                Engine carEngine = engines.FirstOrDefault(e => e.Model == engineModel);
                int weight;
                string color;

                if (data.Length == 4)
                {
                    weight = int.Parse(data[2]);
                    color = data[3];
                    Car car = new Car(carModel, carEngine, weight, color);
                    cars.Add(car);
                }

                else if (data.Length == 3 && int.TryParse(data[2], out weight))
                {
                    Car car = new Car(carModel, carEngine, weight);
                    cars.Add(car);
                }
                else if (data.Length == 3 && !int.TryParse(data[2], out weight))
                {
                    color = data[2];
                    Car car = new Car(carModel, carEngine, color: color);
                    cars.Add(car);
                }
                else
                {
                    Car car = new Car(carModel, carEngine);
                    cars.Add(car);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}