using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] commands = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (commands[0] != "Party!")
            {
                guests = operationChecker(guests, commands[0], commands[1], commands[2]);

                commands = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            if (guests.Count > 0)
            {
                Console.WriteLine(string.Join(", ", guests) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static List<string> operationChecker(List<string> guests, string mainCommand, string secondaryCommand, string condition)
        {
            if (mainCommand == "Double")
            {
                if (secondaryCommand == "StartsWith")
                {
                    foreach (var guest in guests.ToList())
                    {
                        Predicate<string> isValid = x => x.StartsWith(condition);

                        if (isValid(guest))
                        {
                            guests.Insert(guests.IndexOf(guest), guest);
                        }
                    }
                }
                else if (secondaryCommand == "EndsWith")
                {
                    foreach (var guest in guests.ToList())
                    {
                        Predicate<string> isValid = x => x.EndsWith(condition);
                        if (isValid(guest))
                        {
                            guests.Insert(guests.IndexOf(guest), guest);
                        }
                    }
                }
                else
                {
                    int length = int.Parse(condition);
                    foreach (var guest in guests.ToList())
                    {
                        Predicate<string> isValid = x => x.Length.Equals(length);
                        if (isValid(guest))
                        {
                            guests.Insert(guests.IndexOf(guest), guest);
                        }
                    }
                }
            }
            else//Remove
            {
                if (secondaryCommand == "StartsWith")
                {
                    guests.RemoveAll(guest => guest.StartsWith(condition));
                }
                else if (secondaryCommand == "EndsWith")
                {
                    guests.RemoveAll(guest => guest.EndsWith(condition));
                }
                else
                {
                    int length = int.Parse(condition);
                    guests.RemoveAll(guest => guest.Length == length);
                }
            }
            return guests;
        }
    }
}
