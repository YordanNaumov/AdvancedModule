using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Dating_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] malesArray = Console.ReadLine()
                           .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

            Stack<int> males = new Stack<int>(malesArray);

            int[] femalesArray = Console.ReadLine()
               .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Queue<int> females = new Queue<int>(femalesArray);

            int matches = 0;

            while (females.Count > 0 && males.Count > 0)
            {
                bool nullValue = false;
                while (females.Peek() % 25 == 0 && females.Peek() != 0)
                {
                    females.Dequeue();
                    if (females.Count > 0)
                    {
                        females.Dequeue();
                    }
                    if (females.Count == 0)
                    {
                        nullValue = true;
                        break;
                    }
                }

                if (nullValue)
                {
                    break;
                }

                while (males.Peek() % 25 == 0 && males.Peek() != 0)
                {
                    males.Pop();
                    if (males.Count > 0)
                    {
                        males.Pop();
                    }
                    if (males.Count == 0)
                    {
                        nullValue = true;
                        break;
                    }
                }

                if (nullValue)
                {
                    break;
                }

                while (males.Peek() <= 0)
                {
                    males.Pop();
                    if (males.Count == 0)
                    {
                        nullValue = true;
                        break;
                    }
                }

                if (nullValue)
                {
                    break;
                }

                while (females.Peek() <= 0)
                {
                    females.Dequeue();

                    if (females.Count == 0)
                    {
                        nullValue = true;
                        break;
                    }
                }

                if (nullValue)
                {
                    break;
                }

                if (females.Dequeue() == males.Peek())
                {
                    males.Pop();
                    matches++;
                }
                else
                {
                    int temp = males.Pop();
                    males.Push(temp - 2);
                }
            }

            Console.WriteLine($"Matches: {matches}");              

            if (males.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }

            if (females.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
        }  
    }
}
