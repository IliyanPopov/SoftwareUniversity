using System;

public class Car : Vechicle
{
    private double _fuelConsumptionPerKM;

    public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {
    }

    public override double FuelConsumptionPerKM
    {
        get { return this._fuelConsumptionPerKM; }
        set { this._fuelConsumptionPerKM = value + 0.9; }
    }

    public override void Drive(double distance)
    {
        if (this.FuelQuantity < distance * this.FuelConsumptionPerKM)
        {
            throw new ArgumentException("Car needs refueling");
        }
        this.FuelQuantity -= (distance * this.FuelConsumptionPerKM);
    }

    public override void Refuel(double volumeInLiters)
    {
        Validator.ValidateRefueling(volumeInLiters, this.TankCapacity);
        this.FuelQuantity += volumeInLiters;
    }

    public override string ToString()
    {
        return $"Car: {this.FuelQuantity:F2}";
    }
}