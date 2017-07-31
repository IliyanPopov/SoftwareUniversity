using System;

public class Person : IComparable<Person>
{
    public Person(string name, int age, string town)
    {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public string Town { get; private set; }

    public int CompareTo(Person other)
    {
        int result = string.Compare(this.Name, other.Name, StringComparison.Ordinal);

        if (result == 0)
        {
            result = this.Age.CompareTo(other.Age);
        }

        if (result == 0)
        {
            result = string.Compare(this.Town, other.Town, StringComparison.Ordinal);
        }

        return result;
    }
}