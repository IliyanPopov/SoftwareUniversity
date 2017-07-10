using System.Text;

public class Cat : Animal
{
    public Cat(string name, int age, string gender) : base(name, age, gender)
    {
    }

    protected Cat(string name, int age) : base(name, age)
    {
    }

    public override string ProduceSound()
    {
        return "MiauMiau";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(nameof(Cat));
        sb.Append($"{this.Name} {this.Age} {this.Gender}");

        return sb.ToString();
    }
}