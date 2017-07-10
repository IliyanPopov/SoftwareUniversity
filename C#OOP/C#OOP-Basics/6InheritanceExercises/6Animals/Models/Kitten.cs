using System.Text;

public class Kitten : Cat
{
    public Kitten(string name, int age)
        : base(name, age)
    {
        this.Gender = "Female";
    }

    private Kitten(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return "Miau";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(nameof(Kitten));
        sb.Append($"{this.Name} {this.Age} {this.Gender}");

        return sb.ToString();
    }
}