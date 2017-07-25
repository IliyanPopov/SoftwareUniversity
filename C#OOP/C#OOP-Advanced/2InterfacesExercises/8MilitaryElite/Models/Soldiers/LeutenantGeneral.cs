using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, decimal salary,
        IList<ISoldier> privateSoldiers) : base(id, firstName, lastName,
        salary)
    {
        this.Privates = privateSoldiers;
    }


    public IList<ISoldier> Privates { get; private set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{base.ToString()}");
        sb.AppendLine($"Privates:");

        foreach (var privateSoldier in this.Privates)
        {
            sb.AppendLine(privateSoldier.ToString());
        }

        return sb.ToString().Trim();
    }
}