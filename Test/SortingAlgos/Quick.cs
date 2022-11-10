namespace Test.SortingAlgos;

internal class Quick
{
    /// <summary>
    /// Credit: bgsulz
    /// Clones the given array such that we do not modify the original array.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    internal static int[] QuickSort(int[] arr)
    {
        var clone = arr.Clone() as int[];
        QuickSortAlgorithm(arr: clone, leftIndex: 0, rightIndex: clone.Length - 1);
        return clone;
    }

    /// <summary>
    /// Credit: bgsulz
    /// Modifies the given array and sorts according to Quick-sort algo.
    /// </summary>
    /// <param name="arr"></param>
    internal static void QuickSortNonAlloc(int[] arr)
        => QuickSortAlgorithm(arr: arr, leftIndex: 0, rightIndex: arr.Length - 1);

    /// <summary>
    /// Recursive Quick-sort algorithm.
    /// Runtime: O(n log n)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="leftIndex"></param>
    /// <param name="rightIndex"></param>
    /// <returns></returns>
    private static void QuickSortAlgorithm(int[] arr, int leftIndex, int rightIndex)
    {
        if (leftIndex < rightIndex)
        {
            // Partition the array and get the pivot index
            int pivotIndex = Partition(arr, leftIndex, rightIndex);
            // Sort the left side of the pivot
            QuickSortAlgorithm(arr, leftIndex, pivotIndex - 1);
            // Sort the right side of the pivot
            QuickSortAlgorithm(arr, pivotIndex + 1, rightIndex);
        }
    }

    /// <summary>
    /// Partition the array and return the pivot index.
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="leftIndex"></param>
    /// <param name="rightIndex"></param>
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
