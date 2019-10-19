using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        private List<Person> people;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person()
        {
            this.people = new List<Person>();
        }
        public void AddMember(Person member)
        {
            this.people.Add(member);
        }
        public List<Person> GetOldestMembers()
        {
            return this.people.OrderBy(x => x.Name).Where(x => x.Age > 30).ToList();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
