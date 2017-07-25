public class Ferrari : ICar
{
    public Ferrari(string driver)
    {
        this.Model = "488-Spider";
        this.Driver = driver;
    }

    public string Model { get; set; }
    public string Driver { get; set; }

    public string Brake()
    {
        return $"Brakes!";
    }

    public string Accelerate()
    {
        return $"Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brake()}/{this.Accelerate()}/{this.Driver}";
    }
}