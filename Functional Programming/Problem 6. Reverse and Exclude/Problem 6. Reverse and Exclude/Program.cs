using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int divider = int.Parse(Console.ReadLine());

            numbers.Reverse();
            numbers.RemoveAll(x => x % divider == 0);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
