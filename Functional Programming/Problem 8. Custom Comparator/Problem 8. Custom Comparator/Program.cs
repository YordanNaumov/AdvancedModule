using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var listOfNumbers = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            listOfNumbers.AddRange(numbers.Where(x => x % 2 != 0).OrderBy(x => x).ToList());

           Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
