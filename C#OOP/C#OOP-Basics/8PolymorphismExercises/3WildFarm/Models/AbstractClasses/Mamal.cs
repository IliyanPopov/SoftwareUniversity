public abstract class Mamal : Animal
{
    private string _livingRegion;

    public Mamal(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType,
        animalName, animalWeight)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion
    {
        get { return this._livingRegion; }
        set { this._livingRegion = value; }
    }
}