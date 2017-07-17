using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> warHistory;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>
        {
            {"Air", new Nation()},
            {"Fire", new Nation()},
            {"Earth", new Nation()},
            {"Water", new Nation()}
        };
        this.warHistory = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];

        Bender currentBender = this.GetBender(benderArgs);
        this.nations[benderType].AddBender(currentBender);
    }

    private Bender GetBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        var benderName = benderArgs[1];
        var benderPower = int.Parse(benderArgs[2]);
        var benderAuxParam = double.Parse(benderArgs[3]);

        switch (benderType)
        {
            case "Air":
                return new AirBender(benderName, benderPower, benderAuxParam);
            case "Water":
                return new WaterBender(benderName, benderPower, benderAuxParam);
            case "Fire":
                return new FireBender(benderName, benderPower, benderAuxParam);
            case "Earth":
                return new EarthBender(benderName, benderPower, benderAuxParam);
            default:
                throw new NotImplementedException();
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];

        Monument curretMonument = this.GetMonument(monumentArgs);
        this.nations[monumentType].AddMonument(curretMonument);
    }

    private Monument GetMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];
        var monumentName = monumentArgs[1];
        var monumentAffinityPoints = int.Parse(monumentArgs[2]);

        switch (monumentType)
        {
            case "Air":
                return new AirMonument(monumentName, monumentAffinityPoints);
            case "Water":
                return new WaterMonument(monumentName, monumentAffinityPoints);
            case "Fire":
                return new FireMonument(monumentName, monumentAffinityPoints);
            case "Earth":
                return new EarthMonument(monumentName, monumentAffinityPoints);
            default:
                throw new NotImplementedException();
        }

    }

    public string GetStatus(string nationsType)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{nationsType} Nation")
            .Append(this.nations[nationsType]);

        return sb.ToString();
    }

    public void IssueWar(string nationsType)
    {
        double victoriousPower = this.nations.Max(pair => pair.Value.GetTotalPower());

        foreach (var nation in this.nations.Values)
        {
            if (nation.GetTotalPower() != victoriousPower)
            {
                nation.DeclareDefeat();
            }
        }

        this.warHistory.Add($"War {this.warHistory.Count + 1} issued by {nationsType}");
    }

    public string GetWarsRecord()
    {
        return $"{string.Join(Environment.NewLine, this.warHistory)}";
    }
}