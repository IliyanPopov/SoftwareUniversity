using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _8PetClinics.Models;

public class Clinic
{
    private int _roomsCount;
    private readonly int _middleRoom;
    private bool _leftAdd;
    private bool _rightAdd;
    private bool _leftRemove;
    private bool _rightRemove;


    public Clinic(string name, int roomsCount)
    {
        this.Name = name;
        this.RoomsCount = roomsCount;
        this.Rooms = new List<Room>(roomsCount);

        for (int i = 0; i < this.RoomsCount; i++)
        {
            this.Rooms.Add(new Room());
        }

        if (roomsCount == 1)
        {
            this._middleRoom = 0;
        }
        else
        {
            this._middleRoom = this.RoomsCount / 2;
        }
    }

    public IList<Room> Rooms { get; private set; }


    public string Name { get; private set; }

    public int RoomsCount
    {
        get { return this._roomsCount; }
        private set
        {
            if (value % 2 == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            this._roomsCount = value;
        }
    }

    public bool AddPet(Pet pet)
    {
        if (AddPetInMiddleRoom(pet))
        {
            return true;
        }

        if (AddPetFromLeft(pet))
        {
            return true;
        }

        if (AddPetFromRight(pet))
        {
            return true;
        }

        return false;
    }

    private bool AddPetFromRight(Pet pet)
    {
        if (this._rightAdd)
        {
            for (int i = this._middleRoom; i < this.Rooms.Count; i++)
            {
                if (!this.Rooms[i].HasPet)
                {
                    this.Rooms[i].AddPet(pet);
                    this._rightAdd = false;
                    this._leftAdd = true;
                    return true;
                }
            }
        }
        return false;
    }

    private bool AddPetFromLeft(Pet pet)
    {
        if (this._leftAdd)
        {
            for (int i = this._middleRoom; i >= 0; i--)
            {
                if (!this.Rooms[i].HasPet)
                {
                    this.Rooms[i].AddPet(pet);
                    this._leftAdd = false;
                    this._rightAdd = true;
                    return true;
                }
            }
        }
        return false;
    }

    private bool AddPetInMiddleRoom(Pet pet)
    {
        if (!this.Rooms[this._middleRoom].HasPet)
        {
            this.Rooms[this._middleRoom].AddPet(pet);
            this._leftAdd = true;
            return true;
        }
        return false;
    }

    public bool RemovePet()
    {
        if (RemovePetMiddleRoom())
        {
            return true;
        }

        if (RemovePetFromRight())
        {
            return true;
        }

        if (RemovePetFromLeft())
        {
            return true;
        }

        return false;
    }

    private bool RemovePetFromLeft()
    {
        if (this._leftRemove)
        {
            for (int i = 0; i < this._middleRoom; i++)
            {
                if (this.Rooms[i].HasPet)
                {
                    this.Rooms[i].RemovePet();
                    this._leftRemove = false;
                    this._rightRemove = true;
                    return true;
                }
            }
        }
        return false;
    }

    private bool RemovePetFromRight()
    {
        if (this._rightRemove)
        {
            for (int i = this._middleRoom; i < this.Rooms.Count; i++)
            {
                if (this.Rooms[i].HasPet)
                {
                    this.Rooms[i].RemovePet();
                    this._rightRemove = false;
                    this._leftRemove = true;
                    return true;
                }
            }
        }
        return false;
    }

    private bool RemovePetMiddleRoom()
    {
        if (this.Rooms[this._middleRoom].HasPet)
        {
            this.Rooms[this._middleRoom].RemovePet();
            this._rightRemove = true;
            return true;
        }
        return false;
    }

    public bool HasEmptyRooms()
    {
        return this.Rooms.Any(b => b.HasPet == false);
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < this.Rooms.Count; i++)
        {
            sb.AppendLine(this.Rooms[i].ToString());
        }

        return sb.ToString().Trim();
    }
}