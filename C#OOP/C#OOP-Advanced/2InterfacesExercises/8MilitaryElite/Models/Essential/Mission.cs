public class Mission : IMission
{
    public string CodeName { get; set; }

    public MissionState MissionState { get; set; }

    public Mission(string codeName, MissionState missionState)
    {
        this.CodeName = codeName;
        this.MissionState = missionState;
    }

    public override string ToString()
    {
        return $"Code Name: {this.CodeName} State: {this.MissionState}";
    }
}

public enum MissionState
{
    inProgress,
    Finished
}

