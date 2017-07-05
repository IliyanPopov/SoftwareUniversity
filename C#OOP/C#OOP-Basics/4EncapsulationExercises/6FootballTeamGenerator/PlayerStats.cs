namespace _6FootballTeamGenerator
{
    using System;

    public class PlayerStats
    {
        private double _endurance;
        private double _sprint;
        private double _dribble;
        private double _passing;
        private double _shooting;


        public PlayerStats(double endurance, double sprint, double dribble, double passing, double shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        public double Endurance
        {
            get { return this._endurance; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Endurance should be between 0 and 100.");
                }
                this._endurance = value;
            }
        }

        public double Sprint
        {
            get { return this._sprint; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Sprint should be between 0 and 100.");
                }
                this._sprint = value;
            }
        }

        public double Dribble
        {
            get { return this._dribble; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Dribble should be between 0 and 100.");
                }
                this._dribble = value;
            }
        }

        public double Passing
        {
            get { return this._passing; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Passing should be between 0 and 100.");
                }
                this._passing = value;
            }
        }

        public double Shooting
        {
            get { return this._shooting; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Shooting should be between 0 and 100.");
                }
                this._shooting = value;
            }
        }

        public double OverallSkillLevel()
        {
            return ((this._endurance + this._sprint + this._dribble + this._passing + this._shooting) / 5.0);
        }
    }
}