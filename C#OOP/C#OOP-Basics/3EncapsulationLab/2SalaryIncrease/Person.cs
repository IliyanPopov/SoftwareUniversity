public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private double _salary;
    public Person(string firstName, string lastName, int age, double salary)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._age = age;
        this._salary = salary;
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

    public double Salary { get { return this._salary; } }

    public void IncreaseSalary(double bonus)
    {
        if (this.Age < 30)
        {
            this._salary += _salary * ((bonus / 2) / 100);
        }
        else
        {
            this._salary += _salary * (bonus / 100);
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this._salary:F2} leva";
    }
}
