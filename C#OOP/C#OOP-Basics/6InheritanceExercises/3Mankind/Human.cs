using System;

public abstract class Human
{
    private string _firstName;
    private string _lastName;


    protected Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public virtual string FirstName
    {
        get { return this._firstName; }
        set
        {
            if (!char.IsLetter(value[0]) || !char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }

            if (value.Length <= 3)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }

            this._firstName = value;
        }
    }

    public virtual string LastName
    {
        get { return this._lastName; }
        set
        {
            if (!char.IsLetter(value[0]) || !char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }

            if (value.Length <= 2)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            this._lastName = value;
        }
    }
}