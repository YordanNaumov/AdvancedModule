using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var numberAppearance = new Dictionary<int, int>();

            for (int i = 0; i < numberOfLines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (numberAppearance.ContainsKey(number))
                {
                    numberAppearance[number]++;
                }
                else
                {
                    numberAppearance[number] = 1;
                }
            }

            foreach (var number in numberAppearance)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                    break;
                }
            }
        }
    }
}
