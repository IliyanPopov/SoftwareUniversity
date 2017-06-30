namespace _10CarSalesman
{
    using System;

    public class Engine
    {
        public Engine(string model, int power, int dispacement = -1, string efficiency = "n/a")
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = dispacement;
            this.Efficiency = efficiency;
        }
        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            if (this.Displacement == -1)
            {

                return $"{this.Model}: {Environment.NewLine} Power: {this.Power} {Environment.NewLine} Displacement: n/a {Environment.NewLine}  Efficiency: {this.Efficiency}";
            }
            else
            {
                return $"{this.Model}: {Environment.NewLine} Power: {this.Power} {Environment.NewLine} Displacement: {this.Displacement} {Environment.NewLine}  Efficiency: {this.Efficiency}";
            }
        }
    }
}