using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStationRecruitment
{
    class SpaceStation
    {
        private string name;
        private int capacity;
        private List<Astronaut> data;
        public int Count => Data.Count();

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Data = new List<Astronaut>();
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

        public List<Astronaut> Data
        {
            get { return data; }
            set { data = value; }
        }
        public void Add(Astronaut astronaut)
        {
            if (Data.Count < capacity)
            {
                Data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            foreach (var astronaut in Data)
            {
                if (astronaut.Name == name)
                {
                    Data.Remove(astronaut);
                    return true;
                }
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut astronaut = Data.OrderBy(x => x.Age).First();

            return astronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = Data.Where(x => x.Name == name).FirstOrDefault();

            return astronaut;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {Name}:");
            foreach (var astronaut in data)
            {
                sb.AppendLine(astronaut.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
