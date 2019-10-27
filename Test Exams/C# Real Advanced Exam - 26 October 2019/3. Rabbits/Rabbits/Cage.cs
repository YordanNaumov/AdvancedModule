using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
    public class Cage
    {

        private string name;
        private int capacity;
        private List<Rabbit> data;
        public int Count => Data.Count;
        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Rabbit>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public List<Rabbit> Data
        {
            get { return data; }
            set { data = value; }
        }

        public void Add(Rabbit rabbit)
        {
            if (data.Count < capacity)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            foreach (var rabbit in data)
            {
                if (rabbit.Name == name)
                {
                    data.Remove(rabbit);
                    return true;
                }
            }

            return false;
        }

        public void RemoveSpecies(string species)
        {
            foreach (var rabbit in data)
            {
                if (rabbit.Species == species)
                {
                    data.Remove(rabbit);
                }
            }
        }

        public Rabbit SellRabbit(string name)
        {
            foreach (var rabbit in data)
            {
                if (rabbit.Name == name)
                {
                    rabbit.Available = false;
                    return rabbit;
                }
            }
            return null;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> rabbitList = new List<Rabbit>();
            foreach (var rabbit in data)
            {
                if (rabbit.Species == species)
                {
                    rabbit.Available = false;
                    rabbitList.Add(rabbit);
                }
            }
            Rabbit[] soldRabbits = rabbitList.ToArray();

            return soldRabbits;
        }

        public string Report()
        {
            StringBuilder remainingRabbits = new StringBuilder();
            remainingRabbits.AppendLine($"Rabbits available at {Name}:");

            foreach (var rabbit in data)
            {
                if (rabbit.Available)
                {
                    remainingRabbits.AppendLine(rabbit.ToString());
                }
            }
            return remainingRabbits.ToString().TrimEnd();
        }
    }
}
