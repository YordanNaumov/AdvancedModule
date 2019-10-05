using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var names = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (!names.Contains(input))
                {
                    names.Add(input);
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
