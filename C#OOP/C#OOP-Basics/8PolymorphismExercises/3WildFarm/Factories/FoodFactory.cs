using System;

public static class FoodFactory
{
    public static Food CreateFood(string[] foodData)
    {
        switch (foodData[0].ToLower())
        {
            case "vegetable":
                return new Vegetable(int.Parse(foodData[1]));
            case "meat":
                return new Meat(int.Parse(foodData[1]));
            default:
                throw new NotImplementedException();
        }
    }
}