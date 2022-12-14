namespace Test.SortingAlgos;

public class Quick
{
    /// <summary>
    /// Credit: bgsulz
    /// Clones the given array such that we do not modify the original array.
    /// </summary>
    /// <param name="arr">Array to sort.</param>
    /// <returns>Returns a new sorted array.</returns>
    public static int[] Sort(int[] arr)
    {
        var clone = arr.Clone() as int[];
        Algorithm(arr: clone, leftIndex: 0, rightIndex: clone.Length - 1);
        return clone;
    }

    /// <summary>
    /// Credit: bgsulz
    /// Modifies the given array and sorts according to Quick-sort algo.
    /// </summary>
    /// <param name="arr">Array to sort.</param>
    internal static void SortNonAlloc(int[] arr)
        => Algorithm(arr: arr, leftIndex: 0, rightIndex: arr.Length - 1);

    /// <summary>
    /// Recursive Quick-sort algorithm.
    /// Runtime: O(n^2) worst case, O(n log n) average.
    /// </summary>
    /// <param name="arr">The array to sort.</param>
    /// <param name="leftIndex">Left-most index.</param>
    /// <param name="rightIndex">Right-most index.</param>
    /// <returns></returns>
    private static void Algorithm(int[] arr, int leftIndex, int rightIndex)
    {
        if (leftIndex < rightIndex)
        {
            // Partition the array and get the pivot index
            int pivotIndex = Partition(arr, leftIndex, rightIndex);
            // Sort the left side of the pivot
            Algorithm(arr, leftIndex, pivotIndex - 1);
            // Sort the right side of the pivot
            Algorithm(arr, pivotIndex + 1, rightIndex);
        }
    }

    /// <summary>
    /// Partition the array and return the pivot index.
    /// </summary>
    /// <param name="arr">Array to sort.</param>
    /// <param name="leftIndex">Left-most index.</param>
    /// <param name="rightIndex">Right-most index.</param>
    /// <returns></returns>
    private static int Partition(int[] arr, int leftIndex, int rightIndex)
    {
        // Set the pivot to the right-most element
        // Pivot is the element in the array, e.g., {2, 4, 8} would have initial pivot = 8.
        int pivot = arr[rightIndex];
        // Set the left-most element as the initial pivot index
        int i = leftIndex - 1;
        
        for (int j = leftIndex; j < rightIndex; j++)
        {
            // If the current element is less than the pivot
            if (arr[j] < pivot)
            {
                i++;    // Increment the pivot index
                // Swap the current element with the element at the pivot index
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        
        // Swap the pivot with the element at the pivot index
        int temp2 = arr[i + 1];
        arr[i + 1] = arr[rightIndex];
        arr[rightIndex] = temp2;

        // Return the pivot index
        return ++i;
    }
}
