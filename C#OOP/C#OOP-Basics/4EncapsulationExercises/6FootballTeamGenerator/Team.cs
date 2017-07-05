namespace _6FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string _name;
        private List<Player> _players;


        public Team(string name)
        {
            this.Name = name;
            this._players = new List<Player>();
        }
        public string Name
        {
            get { return this._name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this._name = value;
            }
        }

        public int Rating
        {
            get
            {
                double rating = 0;
                foreach (var player in this._players)
                {
                    rating += player.Stats.OverallSkillLevel();
                }

                if (this._players.Count > 0)
                {
                    return (int)(Math.Round(rating / this._players.Count));
                }
                else
                {
                    return 0;
                }
            }
        }

        public void AddPlayer(Player player)
        {
            this._players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this._players.Any(p =>p.Name == playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team. ");
            }
            Player player = this._players.FirstOrDefault(p => p.Name == playerName);
            this._players.Remove(player);
        }
    }
}