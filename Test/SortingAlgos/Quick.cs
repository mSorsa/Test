namespace Test.SortingAlgos;

internal class Quick
{
    /// <summary>
    /// Recursive Quick-sort algorithm.
    /// Runtime: O(n log n)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="leftIndex"></param>
    /// <param name="rightIndex"></param>
    /// <returns></returns>
    internal static int[] QuickSortAlgorithm(int[] arr, int leftIndex, int rightIndex)
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
        return arr;
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
        return i + 1;
    }
}
