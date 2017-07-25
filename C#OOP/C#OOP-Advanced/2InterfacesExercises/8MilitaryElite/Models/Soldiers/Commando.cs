using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(string id, string firstName, string lastName, decimal salary, Corps corps, IList<IMission> missions) : base(id, firstName,
        lastName, salary, corps)
    {
        this.Missions = missions;
    }


    public IList<IMission> Missions { get; private set; }

    public void CompleteMission()
    {
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{base.ToString()}");
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine($"Missions:");

        foreach (var mission in this.Missions)
        {
            sb.AppendLine(mission.ToString());
        }

        return sb.ToString().Trim();
    }

    public void AddMission(Mission mission)
    {
        this.Missions.Add(mission);
    }
}