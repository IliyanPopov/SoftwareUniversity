using System;

public class Bus : Vechicle
{
    public bool HasPeopleInside { get; set; }

    public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        if (this.FuelQuantity <= distance * this.FuelConsumptionPerKM)
        {
            throw new ArgumentException("Bus needs refueling");
        }

        if (!HasPeopleInside)
        {
            this.FuelQuantity -= (distance * this.FuelConsumptionPerKM);
        }
        else
        {
            this.FuelQuantity -= (distance * (this.FuelConsumptionPerKM + 1.4));
        }
    }

    public override void Refuel(double volumeInLiters)
    {
        Validator.ValidateRefueling(volumeInLiters, this.TankCapacity);
        this.FuelQuantity += (volumeInLiters * 0.95);
    }

    public override string ToString()
    {
        return $"Bus: {this.FuelQuantity:F2}";
    }
}

