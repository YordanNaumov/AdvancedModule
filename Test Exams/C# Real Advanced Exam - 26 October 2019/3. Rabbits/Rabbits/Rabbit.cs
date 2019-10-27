using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
    public class Rabbit
    {
        private string name;
        private string species;
        private bool available;

        public Rabbit(string name, string species)
        {
            Name = name;
            Species = species;
            Available = true;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        public override string ToString()
        {
            return $"Rabbit ({Species}): {Name}";
        }
    }
}
