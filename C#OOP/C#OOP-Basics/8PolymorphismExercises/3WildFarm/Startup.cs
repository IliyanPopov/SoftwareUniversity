using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();

        while (input != "End")
        {
            var animalData = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Animal animal = AnimalFactory.CreateAnimal(animalData);
            var foodData = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Food food = FoodFactory.CreateFood(foodData);

            Console.WriteLine(animal.MakeSound());
            try
            {
                animal.Eat(food);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(animal.ToString());
            input = Console.ReadLine();
        }
    }
}

