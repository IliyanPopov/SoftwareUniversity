using System;

public static class Validator
{
    public static void VegetarianValidator(Food food, string currentAnimalNameInPlural)
    {
        if (food.GetType() != typeof(Vegetable))
        {
            throw new ArgumentException($"{currentAnimalNameInPlural} are not eating that type of food!");
        }
    }

    public static void MeatEatingValidator(Food food, string currentAnimalNameInPlural)
    {
        if (food.GetType() != typeof(Meat))
        {
            throw new ArgumentException($"{currentAnimalNameInPlural} are not eating that type of food!");
        }
    }
}

