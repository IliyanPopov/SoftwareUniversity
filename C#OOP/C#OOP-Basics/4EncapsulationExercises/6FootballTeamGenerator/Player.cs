namespace _6FootballTeamGenerator
{
    using System;

    public class Player
    {
        private string _name;

            
        public Player(string name, PlayerStats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        public PlayerStats Stats { get; set; }

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
    }
}