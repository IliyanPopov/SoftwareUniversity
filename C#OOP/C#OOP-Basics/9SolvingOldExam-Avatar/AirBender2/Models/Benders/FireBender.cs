﻿public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public double HeatAggression
    {
        get { return this.heatAggression; }
        private set { this.heatAggression = value; }
    }
    public override double GetPowerPoints()
    {
        return this.Power * this.HeatAggression;
    }
    public override string ToString()
    {
        return $"Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAggression:F2}";
    }
}