public class Citizen : IEntity, INamable, IBirthable, IBuyer
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public int Age { get; private set; }

    public string Birthdate { get; private set; }
    public int Food { get; private set; }

    public void BuyFood()
    {
        this.Food += 10;
    }

    public string Id { get; private set; }

    public string Name { get; private set; }
}