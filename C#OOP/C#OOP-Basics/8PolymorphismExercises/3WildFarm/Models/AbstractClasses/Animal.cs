public abstract class Animal
{
    private string _animalName;

    private string _animalType;

    private double _animalWeight;

    private int _foodEaten;

    protected Animal(string animalType, string animalName, double animalWeight)
    {
        this.AnimalType = animalType;
        this.AnimalName = animalName;
        this.AnimalWeight = animalWeight;
    }

    public string AnimalName
    {
        get { return this._animalName; }
        set { this._animalName = value; }
    }

    public string AnimalType
    {
        get { return this._animalType; }
        set { this._animalType = value; }
    }

    public double AnimalWeight
    {
        get { return this._animalWeight; }
        set { this._animalWeight = value; }
    }

    public int FoodEaten
    {
        get { return this._foodEaten; }
        set { this._foodEaten = value; }
    }

    public abstract string MakeSound();

    public abstract void Eat(Food food);
}