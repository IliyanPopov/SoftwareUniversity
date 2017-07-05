namespace _5PizzaCalories
{
    using System;

    public class Topping
    {
        private const string MeatType = "meat";
        private const string VeggieType = "veggies";
        private const string CheeseType = "cheese";
        private const string SauseType = "sauce";
        private const int MinWeightValue = 1;
        private const int MaxWeightValue = 50;
        private string _type;
        private double _weight;
        private double _calories;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public string Type
        {
            get { return this._type; }
            set
            {
                if (value.ToLower() != MeatType && value.ToLower() != VeggieType && value.ToLower() != CheeseType && value.ToLower() != SauseType)
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this._type =value;
            }
        }

        public double Weight
        {
            get { return this._weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this._type} weight should be in the range [{MinWeightValue}..{MaxWeightValue}].");
                }
                this._weight = value;
            }
        }

        public double Calories
        {
            get
            {
                if (String.Equals(this.Type, MeatType, StringComparison.OrdinalIgnoreCase)) 
                {
                    this._calories = this.Weight * 2 * 1.2;
                }
                else if (String.Equals(this.Type, VeggieType, StringComparison.OrdinalIgnoreCase))
                {
                    this._calories = this.Weight * 2 * 0.8;
                }
                else if (String.Equals(this.Type, CheeseType, StringComparison.OrdinalIgnoreCase))
                {
                    this._calories = this.Weight * 2 * 1.1;
                }
                else if (String.Equals(this.Type, SauseType, StringComparison.OrdinalIgnoreCase))
                {
                    this._calories = this.Weight * 2 * 0.9;
                }

                return this._calories;
            }
        }
    }
}