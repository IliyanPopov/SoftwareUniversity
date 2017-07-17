public class AirBender : Bender
{
    public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    private double aerialIntegrity;

    public double AerialIntegrity
    {
        get { return this.aerialIntegrity; }
        set { this.aerialIntegrity = value; }
    }


    public override double GetPower()
    {
        return this.Power * this.AerialIntegrity;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Aerial Integrity: {this.AerialIntegrity:F2}";
    }
}

