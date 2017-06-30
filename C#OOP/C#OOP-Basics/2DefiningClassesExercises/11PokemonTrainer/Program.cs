namespace _11PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                var data = input
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                string trainerName = data[0];
                string pokemonName = data[1];
                string pokemontElement = data[2];
                int pokemonHealth = int.Parse(data[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemontElement, pokemonHealth);

                if (!trainers.Any(t => t.Name == trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }

                else
                {
                    var trainer = trainers.FirstOrDefault(t => t.Name == trainerName);
                    trainer.Pokemons.Add(pokemon);
                }


                input = Console.ReadLine();
            }

            string input2 = Console.ReadLine();

            while (input2 != "End")
            {
                if (input2 == "Fire")
                {
                    ProcessPokemons(trainers, input2);
                }
                else if (input2 == "Water")
                {
                    ProcessPokemons(trainers, input2);
                }
                else if (input2 == "Electricity")
                {
                    ProcessPokemons(trainers, input2);
                }
                input2 = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t =>t.BadgesCount))
            {
                Console.WriteLine($"{trainer.Name} {trainer.BadgesCount} {trainer.Pokemons.Count}");
            }
        }

        private static void ProcessPokemons(List<Trainer> trainers, string input2)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == input2))
                {
                    trainer.BadgesCount++;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;     
                    }
                    trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                }
            }
        }
    }
}