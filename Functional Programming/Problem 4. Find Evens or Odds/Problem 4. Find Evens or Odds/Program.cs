using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            Predicate<int> isEven = x => (x % 2).Equals(0);

            if (command == "even")
            {
                for (int i = range[0]; i <= range[1]; i++)
                {
                    if (isEven(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                for (int i = range[0]; i <= range[1]; i++)
                {
                    if (isEven(i) == false)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
