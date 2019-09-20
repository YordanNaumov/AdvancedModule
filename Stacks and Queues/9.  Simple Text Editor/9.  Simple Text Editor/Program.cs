using System;
using System.Linq;
using System.Collections.Generic;

namespace _9.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            string currentText = string.Empty;
            var previousText = new Stack<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                int operationType = int.Parse(command[0]);

                switch (operationType)
                {
                    case 1:
                        previousText.Push(currentText);
                        currentText += command[1];
                        break;
                    case 2:
                        int count = currentText.Length - int.Parse(command[1]);
                        previousText.Push(currentText);
                        currentText = currentText.Remove(count);
                        break;
                    case 3:
                        int position = int.Parse(command[1]) - 1;
                        if (position <= currentText.Length)
                        {
                            Console.WriteLine(currentText[position]);
                        }
                        else
                        {
                            Console.WriteLine(currentText[currentText.Length-1]);
                        }
                        break;
                    case 4:
                        if (previousText.Count > 0)
                        {
                            currentText = previousText.Pop();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
