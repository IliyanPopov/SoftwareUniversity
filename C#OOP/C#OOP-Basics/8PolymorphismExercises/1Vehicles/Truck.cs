using System;

public class Truck : Vechicle
{
    private double _fuelConsumptionPerKM;

    public Truck(double fuelQuantity, double fuelConsumptionPerKm, double trunkCapacity) : base(fuelQuantity, fuelConsumptionPerKm, trunkCapacity)
    {
    }

    public override double FuelConsumptionPerKM
    {
        get { return this._fuelConsumptionPerKM; }
        set { this._fuelConsumptionPerKM = value + 1.6; }
    }


    public override void Drive(double distance)
    {
        if (this.FuelQuantity < distance * this.FuelConsumptionPerKM)
        {
            throw new ArgumentException("Truck needs refueling");
        }
        this.FuelQuantity -= (distance * this.FuelConsumptionPerKM);
    }

    public override void Refuel(double volumeInLiters)
    {
        if (volumeInLiters <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        this.FuelQuantity += (volumeInLiters * 0.95);
    }
    public override string ToString()
    {
        return $"Truck: {this.FuelQuantity:F2}";
    }
}

