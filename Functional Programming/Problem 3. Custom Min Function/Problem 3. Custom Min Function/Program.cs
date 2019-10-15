using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            Func<int[], int> minFunc = x => x.Min();

            Console.WriteLine(minFunc(input));
        }
    }
}
