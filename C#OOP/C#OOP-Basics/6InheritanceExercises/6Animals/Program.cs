using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        List<Animal> animals = new List<Animal>();

        while (input != "Beast!")
        {
            var animalType = input;
            var animalData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                if (animalType == "Cat" && animalData.Length > 2)
                {
                    Cat cat = new Cat(animalData[0], int.Parse(animalData[1]), animalData[2]);
                    animals.Add(cat);
                }
                else if (animalType == "Dog" && animalData.Length > 2)
                {
                    Dog dog = new Dog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                    animals.Add(dog);
                }
                else if (animalType == "Frog" && animalData.Length > 2)
                {
                    Frog frog = new Frog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                    animals.Add(frog);
                }
                else if (animalType == "Kitten" && animalData.Length > 1)
                {
                    Kitten kitten = new Kitten(animalData[0], int.Parse(animalData[1]));
                    animals.Add(kitten);
                }
                else if (animalType == "Tomcat" && animalData.Length > 1)
                {
                    Tomcat tomcat = new Tomcat(animalData[0], int.Parse(animalData[1]));
                    animals.Add(tomcat);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            input = Console.ReadLine();
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
            Console.WriteLine(animal.ProduceSound());
        }
    }
}