using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var numbers = Enumerable.Range(1, n);

        int[] dividers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        foreach (var divider in dividers)
        {
            numbers = numbers.Where(num => num % divider == 0);
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}