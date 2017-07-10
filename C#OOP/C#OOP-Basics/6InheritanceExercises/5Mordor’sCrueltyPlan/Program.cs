using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };

        var foodsData = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

        List<Food> foods = new List<Food>();

        foreach (var food in foodsData)
        {
            Food foodObj = FoodFactory.CreateFood(food);
            foods.Add(foodObj);
        }

        int happinessPoints = 0;

        foreach (var food in foods)
        {
            happinessPoints += food.PointsOfHappiness;
        }

        BaseMood mood = MoodFactory.CreateMood(happinessPoints);
        Console.WriteLine(happinessPoints);
        Console.WriteLine(mood.Name);
    }
}