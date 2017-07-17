public class WaterBender : Bender
{
    public WaterBender(string name, int power, double waterClariry) : base(name, power)
    {
        this.WaterClarity = waterClariry;
    }

    private double waterClarity;

    public double WaterClarity
    {
        get { return this.waterClarity; }
        set { this.waterClarity = value; }
    }


    public override double GetPower()
    {
        return this.Power * this.WaterClarity;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Water Clarity: {this.WaterClarity:F2}";
    }
}

