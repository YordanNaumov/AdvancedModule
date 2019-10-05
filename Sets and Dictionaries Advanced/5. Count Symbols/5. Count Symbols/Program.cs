using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var charAppearance = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (charAppearance.ContainsKey(input[i]))
                {
                    charAppearance[input[i]]++;
                }
                else
                {
                    charAppearance[input[i]] = 1;
                }
            }

            charAppearance = charAppearance.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var @char in charAppearance)
            {
                Console.WriteLine($"{@char.Key}: {@char.Value} time/s");
            }
        }
    }
}
