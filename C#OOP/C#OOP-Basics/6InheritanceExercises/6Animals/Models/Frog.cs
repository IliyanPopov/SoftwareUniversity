using System.Text;

public class Frog : Animal
{
    public Frog(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return "Frogggg";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(nameof(Frog));
        sb.Append($"{this.Name} {this.Age} {this.Gender}");

        return sb.ToString();
    }
}