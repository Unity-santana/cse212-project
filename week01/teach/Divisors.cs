using System;
using System.Collections.Generic;

public static class Divisors
{
    public static void Run()
    {
        List<int> divisors = FindDivisors(12);

        Console.WriteLine("Divisors of 12:");

        foreach (int divisor in divisors)
        {
            Console.Write(divisor + " ");
        }

        Console.WriteLine();
    }

    private static List<int> FindDivisors(int number)
    {
        List<int> divisors = new List<int>();

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                divisors.Add(i);
            }
        }

        return divisors;
    }
}