using System.Linq;
using System.Collections.Generic;

namespace Pokemon_Trainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            Badges = 0;
            Pokemons = pokemons;
        }

        public void WinsBadge()
        {
            Badges++;
        }

        public void LosesHealth(Trainer trainer)
        {
            foreach (var pokemon in trainer.Pokemons.ToList())
            {
                pokemon.Health -= 10;

                if (pokemon.Health <= 0)
                {
                    Pokemons.Remove(pokemon);
                }
            }   
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }
    }
}
