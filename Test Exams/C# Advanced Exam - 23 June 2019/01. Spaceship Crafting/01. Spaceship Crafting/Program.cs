using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Spaceship_Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            List<int> items = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            var physicalTable = new Dictionary<string, int>
            {
                ["Glass"] = 25,
                ["Aluminium"] = 50,
                ["Lithium"] = 75,
                ["Carbon fiber"] = 100,
            };

            var collectedMaterials = new Dictionary<string, int>
            {
                ["Glass"] = 0,
                ["Aluminium"] = 0,
                ["Lithium"] = 0,
                ["Carbon fiber"] = 0,
            };

            int uniqueMaterials = 0;

            while (liquids.Count > 0 && items.Count > 0)
            {
                int sum = liquids.Peek() + items[0];
                bool itemNotFound = true;

                foreach (var item in physicalTable)
                {
                    if (sum == item.Value)
                    {
                        itemNotFound = false; 
                        items.RemoveAt(0);

                        if (collectedMaterials[item.Key] == 0)
                        {
                            uniqueMaterials++;
                        }
                        collectedMaterials[item.Key]++;

                        break;
                    }
                }
                liquids.Dequeue();

                if (itemNotFound)
                {
                    items[0] += 3;
                }
            }

            if (uniqueMaterials == 4)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine("Liquids left: " + string.Join(", ", liquids));
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (items.Count > 0)
            {
                Console.WriteLine("Physical items left: " + string.Join(", ", items));
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            collectedMaterials = collectedMaterials.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var material in collectedMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
