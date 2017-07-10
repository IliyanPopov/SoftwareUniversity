using System;

public static class Validator
{
    public static void ValidateFuel(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
    }

    public static void ValidateRefueling(double volumeToAdd, double trunckVolume)
    {
        if (volumeToAdd <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        if (volumeToAdd > trunckVolume)
        {
            throw new ArgumentException("Cannot fit fuel in tank");
        }
    }
}

