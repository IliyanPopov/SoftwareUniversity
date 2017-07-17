public class FireBender : Bender
{
    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    private double heatAggression;

    public double HeatAggression
    {
        get { return this.heatAggression; }
        set { this.heatAggression = value; }
    }

    public override double GetPower()
    {
        return this.Power * this.HeatAggression;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Heat Aggression: {this.HeatAggression:F2}";
    }
}

