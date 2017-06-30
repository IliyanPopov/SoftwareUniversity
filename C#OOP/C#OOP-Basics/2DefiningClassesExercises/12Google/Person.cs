namespace _12Google
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public Company Company { get; set; }

        public Car Car { get; set; }

        public List<Parent> Parents { get; set; }

        public List<Child> Children { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {Environment.NewLine} Company: {this.Company} {Environment.NewLine} Car: {this.Car} {Environment.NewLine}" +
                   $"Pokemon: {string.Join("", this.Pokemons)} {Environment.NewLine} Parents:{string.Join("", this.Parents)} {Environment.NewLine} Children: {string.Join("", this.Children)}";
        }
    }
}