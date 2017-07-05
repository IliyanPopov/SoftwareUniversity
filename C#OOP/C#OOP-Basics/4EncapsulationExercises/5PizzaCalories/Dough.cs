namespace _5PizzaCalories
{
    using System;

    public class Dough
    {
        private const string WhiteFlourType = "white";
        private const string WholegrainFlourType = "wholegrain";
        private const string CrispyBackingTechnique = "crispy";
        private const string ChewyBackingTechnique = "chewy";
        private const string HomemadeBackingTechnique = "homemade";
        private const int MinWeightValue = 1;
        private const int MaxWeightValue = 200;

        private string _bakingtechnique;
        private double _calories;

        private string _flourType;
        private double _weight;

        public Dough(string bakingtechnique, string flourType, double weight)
        {
            this.BakingTechnique = bakingtechnique;
            this.FlourType = flourType;
            this.Weight = weight;
        }

        public Dough()
        {
        }

        public string FlourType
        {
            get { return this._flourType; }
            set
            {
                if (value.ToLower() != WhiteFlourType && value.ToLower() != WholegrainFlourType)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this._flourType = value.ToLower();
            }
        }

        public string BakingTechnique
        {
            get { return this._bakingtechnique; }
            set
            {
                if (value.ToLower() != CrispyBackingTechnique && value.ToLower() != ChewyBackingTechnique &&
                    value.ToLower() != HomemadeBackingTechnique)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this._bakingtechnique = value.ToLower();
            }
        }

        public double Weight
        {
            get { return this._weight; }
            set
            {
                if (value < MinWeightValue || value > MaxWeightValue)
                {
                    throw new ArgumentException(
                        $"Dough weight should be in the range [{MinWeightValue}..{MaxWeightValue}].");
                }
                this._weight = value;
            }
        }

        public double Calories
        {
            get
            {
                if (String.Equals(this._flourType, WhiteFlourType, StringComparison.OrdinalIgnoreCase))
                {
                    if (String.Equals(this._bakingtechnique, CrispyBackingTechnique, StringComparison.OrdinalIgnoreCase))
                    {
                        this._calories = (2 * this.Weight) * 1.5 * 0.9;
                    }
                    else if (String.Equals(this._bakingtechnique, ChewyBackingTechnique, StringComparison.OrdinalIgnoreCase))
                    {
                        this._calories = (2 * this.Weight) * 1.5 * 1.1;
                    }
                    else if (String.Equals(this._bakingtechnique, HomemadeBackingTechnique, StringComparison.OrdinalIgnoreCase))
                    {
                        this._calories = (2 * this.Weight) * 1.5 * 1.0;
                    }
                }

                if (String.Equals(this._flourType, WholegrainFlourType, StringComparison.OrdinalIgnoreCase))
                {
                    if (String.Equals(this._bakingtechnique, CrispyBackingTechnique, StringComparison.OrdinalIgnoreCase))
                    {
                        this._calories = (2 * this.Weight) * 1.0 * 0.9;
                    }
                    else if (String.Equals(this._bakingtechnique, ChewyBackingTechnique, StringComparison.OrdinalIgnoreCase))
                    {
                        this._calories = (2 * this.Weight) * 1.0 * 1.1;
                    }
                    else if (String.Equals(this._bakingtechnique, HomemadeBackingTechnique, StringComparison.OrdinalIgnoreCase))
                    {
                        this._calories = (2 * this.Weight) * 1.0 * 1.0;
                    }
                }
                return this._calories;
            }
        }
    }
}