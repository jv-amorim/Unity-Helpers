using System;

public static class ArrayExtensions
{
    /// <summary>
    /// Fisher-Yates algorithm to perform shuffling in arrays. Complexity: O(n).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="rng"></param>
    /// <param name="array"></param>
    public static T[] Shuffle<T>(this T[] array)
    {
        Random rng = new Random();
        int n = array.Length;

        while (n > 1)
        {
            int k = rng.Next(n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }

        return array;
    }
}