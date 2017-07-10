using System;
using System.Text;

public abstract class Animal
{
    private string _name;
    private string _gender;

    protected Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    protected Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public string Name
    {
        get { return this._name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            this._name = value;
        }
    }

    private int _age;

    public int Age
    {
        get { return this._age; }
        set
        {
            if (string.IsNullOrWhiteSpace(value.ToString()) || value <= 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            this._age = value;
        }
    }

    public string Gender
    {
        get { return this._gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
            {
                throw new ArgumentException("Invalid input!");
            }
            this._gender = value;
        }
    }

    public abstract string ProduceSound();
}

