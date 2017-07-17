public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power, double waterClarity) : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public double WaterClarity
    {
        get { return this.waterClarity; }
        private set { this.waterClarity = value; }
    }

    public override double GetPowerPoints()
    {
        return this.Power * this.WaterClarity;
    }

    public override string ToString()
    {
        return $"Water Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.WaterClarity:F2}";
    }
}