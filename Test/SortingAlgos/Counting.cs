using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test.SortingAlgos
{
    public class Counting
    {
        /// <summary>
        /// Credit: bgsulz
        /// Clones the given array such that we do not modify the original array.
        /// </summary>
        /// <param name="arr">Array to be sorted.</param>
        /// <returns>Returns the sorted array.</returns>
        public static int[] Sort(int[] arr)
        {
            var clone = (arr is null) ? throw new ArgumentNullException() : arr.Clone() as int[];
            Algorithm(arr: clone);
            return clone;
        }
        
        private static void Algorithm(int[]? arr)
        {
            // Find the maximum value in the array
            int max = arr.Max();

            // Create a new array of length max + 1
            int[] counts = new int[max + 1];

            // Count the number of times each value appears in the array
            foreach (int value in arr)
                counts[value]++;

            // Modify the counts array such that each index stores the sum of the previous counts
            for (int i = 1; i < counts.Length; i++)
                counts[i] += counts[i - 1];

            // Create a new array to store the sorted values
            int[] sorted = new int[arr.Length];

            // Place each value in the correct index of the sorted array
            foreach (int value in arr)
                sorted[--counts[value]] = value;

            // Copy the sorted values back into the original array
            sorted.CopyTo(arr, 0);
        }
    }
}
