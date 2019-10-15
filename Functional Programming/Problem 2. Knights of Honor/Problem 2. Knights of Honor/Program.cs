using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string> print = text => Console.WriteLine("Sir " + text);

            foreach (var text in input)
            {
                print(text);
            }
        }
    }
}
