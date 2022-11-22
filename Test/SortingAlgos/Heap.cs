namespace Test.SortingAlgos;

public class Heap
{
    /// <summary>
    /// Credit: bgsulz
    /// Clones the given array such that we do not modify the original array.
    /// </summary>
    /// <param name="arr">Array to be sorted.</param>
    /// <returns>Returns the sorted array.</returns>
    public static int[] Sort(int[] arr){
        var clone = arr.Clone() as int[];
        Algorithm(arr: clone, leftIndex: 0, rightIndex: clone.Length - 1);
        return clone;
    }

    /// <summary>
    /// Heapsort algorithm
    /// Runtime: O(n log n) 
    /// </summary>
    /// <param name="arr">Array to be sorted.</param>
    /// <param name="leftIndex">Left-most element.</param>
    /// <param name="rightIndex">Right-most element.</param>
    private static void Algorithm(int[] arr, int leftIndex, int rightIndex)
    {        
        // Build the heap
        for (int i = arr.Length / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, arr.Length, i);
        }
        
        // Extract the elements from the heap
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            // Move current root to end
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            
            // Heapify the reduced heap
            Heapify(arr, i, 0);
        }
    }

    private static void Heapify(int[] arr, int length, int i)
    {
        // Find the largest among root, left child and right child
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        
        if (left < length && arr[left] > arr[largest])
        {
            largest = left;
        }
        
        if (right < length && arr[right] > arr[largest])
        {
            largest = right;
        }
        
        // Swap and continue heapifying if root is not largest
        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;
            Heapify(arr, length, largest);
        }
    }
}
