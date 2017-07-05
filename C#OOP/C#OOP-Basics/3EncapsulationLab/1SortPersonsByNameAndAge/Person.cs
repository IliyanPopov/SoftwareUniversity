public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public Person(string firstName, string lastName, int age)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._age = age;
    }
    public string FirstName
    {
        get { return this._firstName; }
    }

    public string LastName
    {
        get { return this._lastName; }
    }

    public int Age { get { return this._age; } }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is a {this.Age} years old";
    }
}
