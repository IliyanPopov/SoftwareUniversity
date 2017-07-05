using System.Collections.Generic;

public class Team
{
    private List<Person> _firstTeam;
    private string _name;
    private List<Person> _reserveTeam;

    public Team(string name)
    {
        this._name = name;
        this._firstTeam = new List<Person>();
        this._reserveTeam = new List<Person>();
    }

    public IReadOnlyCollection<Person> FirstTeam => this._firstTeam.AsReadOnly();

    public IReadOnlyCollection<Person> ReserveTeam => this._reserveTeam.AsReadOnly();

    public void AddPlayer(Person player)
    {
        if (player.Age < 40)
        {
            this._firstTeam.Add(player);
        }
        else
        {
            this._reserveTeam.Add(player);
        }
    }
}