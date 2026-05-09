using System;
using System.Collections.Generic;

public static class ArraySelector
{
    public static void Run()
    {
        int[] array1 = { 1, 2, 3, 4 };
        int[] array2 = { 10, 20, 30, 40 };
        int[] selector = { 1, 1, 2, 2, 1, 1, 2, 2 };

        List<int> result = ListSelector(array1, array2, selector);

        Console.WriteLine("Combined Array:");

        foreach (int item in result)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }

    private static List<int> ListSelector(
        int[] array1,
        int[] array2,
        int[] selector)
    {
        List<int> result = new List<int>();

        int array1Index = 0;
        int array2Index = 0;

        foreach (int value in selector)
        {
            if (value == 1)
            {
                result.Add(array1[array1Index]);
                array1Index++;
            }
            else if (value == 2)
            {
                result.Add(array2[array2Index]);
                array2Index++;
            }
        }

        return result;
    }
}