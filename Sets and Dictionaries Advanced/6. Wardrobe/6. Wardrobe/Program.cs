using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < inputLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = input[0];

                string[] items = input[1]
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();

                    foreach (var item in items)
                    {
                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color][item] = 1;
                        }
                    }
                }
                else
                {
                    foreach (var item in items)
                    {
                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color][item] = 1;
                        }
                    }
                }
            }

            string[] finalCommand = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var items in wardrobe)
            {
                Console.WriteLine($"{items.Key} clothes:");

                bool colorFound = false;

                if (finalCommand[0] == items.Key)
                {
                    colorFound = true;
                }
                foreach (var indinidualItem in items.Value)
                {
                    if (colorFound && indinidualItem.Key == finalCommand[1])
                    {
                        Console.WriteLine($"* {indinidualItem.Key} - {indinidualItem.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {indinidualItem.Key} - {indinidualItem.Value}");
                    }
                }
            }
        }
    }
}
