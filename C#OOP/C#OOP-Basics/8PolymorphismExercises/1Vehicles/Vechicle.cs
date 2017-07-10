using System;

public abstract class Vechicle
{
    private double _fuelConsumptionPerKM;
    private double _fuelQuantity;
    private double _tankCapacity;

    protected Vechicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKM = fuelConsumptionPerKm;
        this.TankCapacity = tankCapacity;
    }

    public virtual double TankCapacity
    {
        get { return this._tankCapacity; }
        set
        {
            Validator.ValidateFuel(value);
            this._tankCapacity = value;
        }
    }

    public virtual double FuelQuantity
    {
        get { return this._fuelQuantity; }
        set
        {
            Validator.ValidateFuel(value);
            this._fuelQuantity = value;
        }
    }

    public virtual double FuelConsumptionPerKM
    {
        get { return this._fuelConsumptionPerKM; }
        set
        {
            Validator.ValidateFuel(value);
            this._fuelConsumptionPerKM = value;
        }
    }

    public abstract void Drive(double distance);

    public abstract void Refuel(double volumeInLiters);
}