using System;
using System.Diagnostics;

public static class Algorithms
{
    public static void Run()
    {
        Console.WriteLine("n\talg1-count\talg2-count\talg3-count");

        int n = 10;

        while (n <= 10000)
        {
            int count1 = Algorithm1(n);
            int count2 = Algorithm2(n);
            int count3 = Algorithm3(n);

            Console.WriteLine(
                $"{n}\t{count1}\t\t{count2}\t\t{count3}");

            n *= 10;
        }

        Console.WriteLine("\nBig O Predictions:");
        Console.WriteLine("Algorithm1 = O(n)");
        Console.WriteLine("Algorithm2 = O(n^2)");
        Console.WriteLine("Algorithm3 = O(log n)");
    }

    private static int Algorithm1(int n)
    {
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            count++;
        }

        return count;
    }

    private static int Algorithm2(int n)
    {
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                count++;
            }
        }

        return count;
    }

    private static int Algorithm3(int n)
    {
        int count = 0;

        while (n > 1)
        {
            n = n / 2;
            count++;
        }

        return count;
    }
}