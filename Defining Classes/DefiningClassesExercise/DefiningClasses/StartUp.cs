using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var people = new Person();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);

                var person = new Person(name, age);
                people.AddMember(person);
            }

            var oldestMembers = people.GetOldestMembers();

            foreach (var oldestMember in oldestMembers)
            {
                Console.WriteLine(oldestMember.Name + " - " + oldestMember.Age);
            }
        }
    }
}
