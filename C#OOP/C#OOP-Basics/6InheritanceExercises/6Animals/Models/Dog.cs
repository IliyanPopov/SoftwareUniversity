using System.Text;

public class Dog : Animal
{
    public Dog(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return "BauBau";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(nameof(Dog));
        sb.Append($"{this.Name} {this.Age} {this.Gender}");

        return sb.ToString();
    }
}