namespace _10CarSalesman
{
    using System;

    public class Car
    {
        public Car(string model, Engine engine, int weight = -1, string color = "n/a")
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            if (this.Weight == -1)
            {
                return $"{this.Model}: {Environment.NewLine} {this.Engine} {Environment.NewLine} Weight: n/a {Environment.NewLine} Color: {this.Color} ";
            }
            else
            {
                return $"{this.Model}: {Environment.NewLine} {this.Engine} {Environment.NewLine} Weight: {this.Weight} {Environment.NewLine} Color: {this.Color} ";
            }
        }
    }
}