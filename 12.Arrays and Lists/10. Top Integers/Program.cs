using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        List<int> numbers = new List<int>();
        foreach (string num in input)
        {
            numbers.Add(int.Parse(num));
        }

        List<int> tops = FindTopIntegers(numbers);

        foreach (int top in tops)
        {
            Console.Write(top + " ");
        }
    }

    public static List<int> FindTopIntegers(List<int> numbers)
    {
        List<int> tops = new List<int>();
        int max = int.MinValue;

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
                tops.Add(max);
            }
        }

        return tops;
    }
}