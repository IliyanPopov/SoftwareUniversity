namespace _7SpeedRacing
{
    using System;

    public class Car
    {
        public Car()
        {
            this.DistanceTraveled = 0;
        }

        public double FuelAmount { get; set; }

        public string Model { get; set; }


        public double FuelConsumptionPerKilometer { get; set; }

        public double DistanceTraveled { get; set; }

        public void TravelDistance(double distance)
        {
            if ((this.FuelConsumptionPerKilometer * distance) > this.FuelAmount)
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
            else
            {
                this.DistanceTraveled += distance;
                this.FuelAmount -= this.FuelConsumptionPerKilometer * distance;
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.DistanceTraveled}";
        }
    }
}