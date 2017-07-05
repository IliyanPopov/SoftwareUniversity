namespace _5PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Pizza
    {
        private string _name;
        private long _numberOfToppings;
        public Dough Dough { get; set; }
        private List<Topping> _toppings;

        public Pizza(string name, long numberOfToppings)
        {
            this.Name = name;
            this.NumberOfToppings = numberOfToppings;
            this._toppings = new List<Topping>();
        }

        public Pizza()
        {
            this._toppings = new List<Topping>();
        }

        public string Name
        {
            get { return this._name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this._name = value;
            }
        }

        public long NumberOfToppings
        {
            get { return this._numberOfToppings; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this._numberOfToppings = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this._toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this._toppings.Add(topping);
        }

        public double TotalCalories
        {
            get
            {
                double calories = 0;
                foreach (var topping in this._toppings)
                {
                    calories += topping.Calories;
                }
                calories += this.Dough.Calories;

                return calories;
            }
        }
    }
}