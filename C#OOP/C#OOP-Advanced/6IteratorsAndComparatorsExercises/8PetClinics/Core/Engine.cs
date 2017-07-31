using System;
using System.Collections.Generic;
using System.Linq;

public class Engine : IEngine
{
    private readonly IList<Clinic> _clinics;
    private readonly IList<Pet> _pets;

    public Engine()
    {
        this._clinics = new List<Clinic>();
        this._pets = new List<Pet>();
    }

    public void Run()
    {
        int roomsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < roomsCount; i++)
        {
            var data = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            switch (data[0])
            {
                case "Create":
                    if (data[1] == "Pet")
                    {
                        CreatePet(data[2], int.Parse(data[3]), data[4]);
                    }
                    else if (data[1] == "Clinic")
                    {
                        try
                        {
                            CreateClinic(data[2], int.Parse(data[3]));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    break;
                case "Add":
                    Console.WriteLine(AddPetInClinic(data[1], data[2]));
                    break;
                case "Release":
                    Console.WriteLine(RemovePetFromClinic(data[1]));
                    break;
                case "HasEmptyRooms":
                    Console.WriteLine(HasEmptyRooms(data[1]));
                    break;
                case "Print":
                    if (data.Length == 2)
                    {
                        Console.WriteLine(Print(data[1]));
                    }
                    else if (data.Length == 3)
                    {
                        Console.WriteLine(Print(data[1], int.Parse(data[2])));
                    }
                    break;
            }
        }
    }

    private void CreatePet(string name, int age, string kind)
    {
        Pet pet = new Pet(name, age, kind);
        this._pets.Add(pet);
    }

    private void CreateClinic(string name, int roomsCount)
    {
        Clinic clinic = new Clinic(name, roomsCount);
        this._clinics.Add(clinic);
    }

    private bool AddPetInClinic(string petName, string clinicName)
    {
        var clinic = this._clinics.FirstOrDefault(c => c.Name == clinicName);
        var pet = this._pets.FirstOrDefault(p => p.Name == petName);
        return clinic.AddPet(pet);
    }

    private bool RemovePetFromClinic(string clinicName)
    {
        var clinic = this._clinics.FirstOrDefault(c => c.Name == clinicName);
        return clinic.RemovePet();
    }

    private bool HasEmptyRooms(string clinicName)
    {
        var clinic = this._clinics.FirstOrDefault(c => c.Name == clinicName);
        return clinic.HasEmptyRooms();
    }

    private string Print(string clinicName)
    {
        var clinic = this._clinics.FirstOrDefault(c => c.Name == clinicName);
        return clinic.ToString();
    }

    private string Print(string clinicName, int roomNumber)
    {
        var room = this._clinics.FirstOrDefault(c => c.Name == clinicName).Rooms[roomNumber - 1];
        return room.ToString();
    }
}