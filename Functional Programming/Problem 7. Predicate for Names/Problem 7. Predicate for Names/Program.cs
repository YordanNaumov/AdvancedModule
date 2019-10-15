using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLength = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split().ToList();

            names.RemoveAll(x => x.Length > maxLength);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
