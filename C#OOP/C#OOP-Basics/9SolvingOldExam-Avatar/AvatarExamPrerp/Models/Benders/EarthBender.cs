public class EarthBender : Bender
{
    public EarthBender(string name, int power, double groundSaturation) : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    private double groundSaturation;

    public double GroundSaturation
    {
        get { return this.groundSaturation; }
        set { this.groundSaturation = value; }
    }

    public override double GetPower()
    {
        return this.Power * this.GroundSaturation;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Ground Saturation: {this.GroundSaturation:F2}";
    }
}

