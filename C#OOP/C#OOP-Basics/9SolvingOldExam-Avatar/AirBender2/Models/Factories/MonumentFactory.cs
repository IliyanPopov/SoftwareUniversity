using System;
using System.Collections.Generic;

public static class MonumentFactory
{
    public static Monument GetMonument(List<string> benderArgs)
    {
        string type = benderArgs[0];
        string name = benderArgs[1];
        int affinity = int.Parse(benderArgs[2]);

        switch (type)
        {
            case "Air":
                return new AirMonument(name, affinity);
            case "Water":
                return new WaterMonument(name, affinity);
            case "Earth":
                return new EarthMonument(name, affinity);
            case "Fire":
                return new FireMonument(name, affinity);
            default:
                throw new NotImplementedException();
        }
    }
}

