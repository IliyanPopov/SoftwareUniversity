﻿namespace _11PokemonTrainer
{
    using System.Collections.Generic;

    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.BadgesCount = 0;
            this.Pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }

        public int BadgesCount { get; set; }

        public List<Pokemon> Pokemons { get; set; }
    }
}