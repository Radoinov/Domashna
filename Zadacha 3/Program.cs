﻿namespace Zadacha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dai chisla: ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] >= 0)
                {
                    result.Add(numbers[i]);
                }
            }
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }
}
