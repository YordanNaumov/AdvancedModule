using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();

        if (input.Length % 2 != 0)
        {
            Console.WriteLine("NO");
            return;
        }

        var openingBrackets = new Stack<char>();
        var bracketPairs = new Dictionary<char, char>
        {
            {'(', ')'}, {'[', ']'}, {'{', '}'}
        };

        for (int i = 0; i < input.Length; i++)
        {
            char @char = input[i];

            if (@char == '(' || @char == '{' || @char == '[')
            {
                openingBrackets.Push(@char);
            }
            else if (openingBrackets.Count == 0)
            {
                Console.WriteLine("NO");
                return;
            }
            else
            {
                char lastOpeningBracket = openingBrackets.Pop();
                char exprectedBracket = bracketPairs[lastOpeningBracket];

                if (@char != exprectedBracket)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
        }

        Console.WriteLine("YES");
    }
}