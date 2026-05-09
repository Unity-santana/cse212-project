using System;
using System.Collections.Generic;

public static class Arrays
{
    public static double[] MultiplesOf(double startingNumber, int count)
    {
        // STEP 1:
        // Create an array that will store the multiples.
        // The size of the array should equal the count provided.
        double[] result = new double[count];

        // STEP 2:
        // Loop through each position in the array.
        for (int i = 0; i < count; i++)
        {
            // STEP 3:
            // Calculate the multiple for the current position.
            // Since arrays start at index 0, we use (i + 1).
            // Example:
            // i = 0 → 3 * 1 = 3
            // i = 1 → 3 * 2 = 6
            result[i] = startingNumber * (i + 1);
        }

        // STEP 4:
        // Return the completed array.
        return result;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // STEP 1:
        // Determine where the list should be split.
        // Example:
        // If count = 9 and amount = 3
        // splitIndex = 9 - 3 = 6
        int splitIndex = data.Count - amount;

        // STEP 2:
        // Create a list containing the last part of the original list.
        // Example:
        // {7,8,9}
        List<int> endPart = data.GetRange(splitIndex, amount);

        // STEP 3:
        // Create a list containing the beginning part.
        // Example:
        // {1,2,3,4,5,6}
        List<int> beginningPart = data.GetRange(0, splitIndex);

        // STEP 4:
        // Clear the original list so we can rebuild it.
        data.Clear();

        // STEP 5:
        // Add the end section first.
        data.AddRange(endPart);

        // STEP 6:
        // Add the beginning section after it.
        data.AddRange(beginningPart);
    }
}