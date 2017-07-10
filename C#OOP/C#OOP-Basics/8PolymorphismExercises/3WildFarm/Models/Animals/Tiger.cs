public class Tiger : Felime
{
    public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalName,
        animalType, animalWeight, livingRegion)
    {
    }

    public override string MakeSound()
    {
        return "ROAAR!!!";
    }

    public override void Eat(Food food)
    {
        Validator.MeatEatingValidator(food, "Tigers");
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}