using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var @string in input)
                {
                    set.Add(@string);
                } 
            }
            List<string> list = new List<string>(set.OrderBy(x => x));

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
