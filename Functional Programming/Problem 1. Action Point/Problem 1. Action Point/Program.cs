using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            Action<string> print = text => Console.WriteLine(text);

            foreach (var text in input)
            {
                print(text);
            }
        }
    }
}
