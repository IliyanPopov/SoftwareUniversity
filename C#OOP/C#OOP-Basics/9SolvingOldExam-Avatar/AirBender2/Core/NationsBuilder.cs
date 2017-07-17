using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> warHistory;
    private int warCounter = 0;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>
        {
            {"Air", new Nation()},
            {"Water", new Nation()},
            {"Fire", new Nation()},
            {"Earth", new Nation()}
        };

        this.warHistory = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        string type = benderArgs[0];
        Bender bender = BenderFactory.GetBender(benderArgs);
        this.nations[type].AddBender(bender);
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        string type = monumentArgs[0];
        Monument monument = MonumentFactory.GetMonument(monumentArgs);
        this.nations[type].AddMonument(monument);
    }

    public string GetStatus(string nationsType)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");
        sb.Append(this.nations[nationsType]);
        return sb.ToString().Trim();
    }

    public void IssueWar(string nationsType)
    {
        var maxPoints = this.nations.Values.Max(n => n.GetTotalPowerPoints());

        foreach (var nation in this.nations.Values)
        {
            if (Math.Abs(nation.GetTotalPowerPoints() - maxPoints) > 0.0001)
            {
                nation.DestroyBenders();
                nation.DestroyMonuments();
            }
        }

        this.warCounter++;
        this.warHistory.Add($"War {this.warCounter} issued by {nationsType}");
    }

    public string GetWarsRecord()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var history in this.warHistory)
        {
            sb.AppendLine(history);
        }

        return sb.ToString().Trim();
    }
}