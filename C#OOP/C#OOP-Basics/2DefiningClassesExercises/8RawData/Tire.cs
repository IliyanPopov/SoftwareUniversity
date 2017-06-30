namespace _8RawData
{
    public class Tire
    {
        public Tire(double age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
        public double Age { get; set; }

        public double Pressure { get; set; }
    }
}