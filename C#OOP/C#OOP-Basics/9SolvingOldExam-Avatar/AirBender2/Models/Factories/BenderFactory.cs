using System;
using System.Collections.Generic;

public static class BenderFactory
{
    public static Bender GetBender(List<string> benderArgs)
    {
        string type = benderArgs[0];
        string name = benderArgs[1];
        int power = int.Parse(benderArgs[2]);
        double points = double.Parse(benderArgs[3]);

        switch (type)
        {
            case "Air":
                return new AirBender(name, power, points);
            case "Water":
                return new WaterBender(name, power, points);
            case "Earth":
                return new EarthBender(name, power, points);
            case "Fire":
                return new FireBender(name, power, points);
            default:
                throw new NotImplementedException();
        }
    }
}

