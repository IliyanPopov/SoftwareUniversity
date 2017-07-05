using System;

public class Person
{
    private int _age;
    private string _firstName;
    private string _lastName;
    private double _salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get { return this._firstName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot be less than 3 symbols");
            }
            this._firstName = value;
        }
    }

    public string LastName
    {
        get { return this._lastName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot be less than 3 symbols");
            }
            this._lastName = value;
        }
    }

    public int Age
    {
        get { return this._age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }
            this._age = value;
        }
    }

    public double Salary
    {
        get { return this._salary; }
        set
        {
            if (value < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva");
            }
            this._salary = value;
        }
    }

    public void IncreaseSalary(double bonus)
    {
        if (this.Age < 30)
        {
            this._salary += this._salary * ((bonus / 2) / 100);
        }
        else
        {
            this._salary += this._salary * (bonus / 100);
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this._salary:F2} leva";
    }
}