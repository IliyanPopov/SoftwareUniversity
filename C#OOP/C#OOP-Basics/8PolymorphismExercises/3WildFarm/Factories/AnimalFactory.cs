using System;

public static class AnimalFactory
{
    public static Animal CreateAnimal(string[] animalData)
    {
        switch (animalData[0].ToLower())
        {
            case "cat":
                return new Cat(animalData[0], animalData[1], double.Parse(animalData[2]), animalData[3], animalData[4]);
            case "tiger":
                return new Tiger(animalData[0], animalData[1], double.Parse(animalData[2]), animalData[3]);
            case "zebra":
                return new Zebra(animalData[0], animalData[1], double.Parse(animalData[2]), animalData[3]);
            case "mouse":
                return new Mouse(animalData[0], animalData[1], double.Parse(animalData[2]), animalData[3]);
            default:
                throw new NotImplementedException();
        }
    }
}