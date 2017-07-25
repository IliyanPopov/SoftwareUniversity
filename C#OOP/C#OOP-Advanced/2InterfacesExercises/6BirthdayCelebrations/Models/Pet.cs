public class Pet : INamable, IBirthable
{
    public Pet(string name, string birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }

    public string Birthdate { get; }

    public string Name { get; }
}