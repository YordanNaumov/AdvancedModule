using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var setToPrint = new HashSet<int>();
            var list = new List<int>();

            for (int i = 0; i < inputNumbers[0] + inputNumbers[1]; i++)
            {
                list.Add(int.Parse(Console.ReadLine())); 
            }

            for (int i = inputNumbers[0]; i < inputNumbers[0] + inputNumbers[1]; i++)
            {
                secondSet.Add(list[i]);
            }

            for (int i = 0; i < inputNumbers[0]; i++)
            {
                int number = list[i];
                firstSet.Add(number);

                if (firstSet.Contains(number) && secondSet.Contains(number))
                {
                    setToPrint.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", setToPrint));
        }
    }
}
