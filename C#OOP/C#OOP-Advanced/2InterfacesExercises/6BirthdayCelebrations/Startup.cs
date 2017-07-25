using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        IList<IBirthable> citizensAndPets = new List<IBirthable>();

        string input = Console.ReadLine();

        while (input != "End")
        {
            var data = input.Split(' ').ToList();

            switch (data[0])
            {
                case "Citizen":
                    string name = data[1];
                    int age = int.Parse(data[2]);
                    string id = data[3];
                    string birthDate = data[4];
                    IBirthable citizen = new Citizen(name, age, id, birthDate);
                    citizensAndPets.Add(citizen);
                    break;

                case "Pet":
                    string petName = data[1];
                    string petBirthday = data[2];
                    IBirthable pet = new Pet(petName, petBirthday);
                    citizensAndPets.Add(pet);
                    break;
            }

            input = Console.ReadLine();
        }
        string yearToMatch = Console.ReadLine();

        foreach (var citizenOrPer in citizensAndPets.Where(czp => czp.Birthdate.EndsWith(yearToMatch)))
        {
            Console.WriteLine(citizenOrPer.Birthdate);
        }
    }
}

