using System;
using System.Linq;
using System.Collections.Generic;

namespace Pokemon_Trainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, List < Pokemon >> trainersAndPokemons = new Dictionary<string, List<Pokemon>>();   
            
            while (command[0] != "Tournament")
            {
                string trainerName = command[0];

                string pokemonName = command[1];
                string pokemonElement = command[2];
                int pokemonHealth = int.Parse(command[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainersAndPokemons.ContainsKey(trainerName))
                {
                    trainersAndPokemons[trainerName] = new List<Pokemon>();
                }
                trainersAndPokemons[trainerName].Add(pokemon);

                command = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            List<Trainer> trainers = new List<Trainer>();

            foreach (var trainerAndPokemon in trainersAndPokemons)
            {
                Trainer trainer = new Trainer(trainerAndPokemon.Key, trainerAndPokemon.Value);
                trainers.Add(trainer);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var trainer in trainers)
                {
                    bool containsElement = trainer.Pokemons.Any(x => x.Element.Equals(input));

                    if (containsElement)
                    {
                        trainer.WinsBadge();
                    }
                    else
                    {
                        trainer.LosesHealth(trainer);
                    }
                }

                input = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(trainer => trainer.Badges).ToList();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
