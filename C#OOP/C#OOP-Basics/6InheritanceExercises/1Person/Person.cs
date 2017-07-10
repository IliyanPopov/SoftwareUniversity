using System;
using System.Text;

public class Person
{
    private int _age;
    private string _name;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public virtual string Name
    {
        get { return this._name; }
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name's length should not be less than 3 symbols!");
            }
            this._name = value;
        }
    }

    public virtual int Age
    {
        get { return this._age; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            this._age = value;
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(string.Format("Name: {0}, Age: {1}", this.Name, this.Age));

        return stringBuilder.ToString();
    }
}