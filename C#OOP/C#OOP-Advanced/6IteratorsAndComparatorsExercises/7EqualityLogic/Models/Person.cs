using System;
public class Person : IComparable<Person>
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public override bool Equals(object obj)
    {
        var item = obj as Person;

        if (item == null)
        {
            return false;
        }

        return this.Name.Equals(item.Name) && this.Age.Equals(item.Age);
    }

    public override int GetHashCode()
    {
        int hash = 13;
        hash = (hash * 7) + this.Name.GetHashCode();
        hash = (hash * 7) + this.Age.GetHashCode();

        return hash;
    }

    public int CompareTo(Person other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var nameComparison = string.Compare(this.Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;
        return this.Age.CompareTo(other.Age);
    }
}