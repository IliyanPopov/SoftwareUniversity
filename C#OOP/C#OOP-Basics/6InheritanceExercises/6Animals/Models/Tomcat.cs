using System.Text;

public class Tomcat : Cat
{
    private Tomcat(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public Tomcat(string name, int age) : base(name, age)
    {
        this.Gender = "Male";
    }

    public override string ProduceSound()
    {
        return "Give me one million b***h";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(nameof(Kitten));
        sb.Append($"{this.Name} {this.Age} {this.Gender}");

        return sb.ToString();
    }
}