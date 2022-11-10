namespace Test.SortingAlgos;

internal class Insertion
{
    /// <summary>
    /// Credit: bgsulz
    /// Clones the given array such that we do not modify the original array.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    internal static int[] Sort(int[] arr)
    {
        var clone = arr.Clone() as int[];
        Algorithm(arr: clone);
        return clone;
    }
    
    /// <summary>
    /// Insertion sort algorithm.
    /// Runtime: O(n^2)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    private static int[] Algorithm(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            // Set the current element as the key
            int j = i;
            while (j > 0 && arr[j - 1] > arr[j])
            {
                // Swap the elements
                int temp = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = temp;
                j--;
            }
        }
        return arr;
    }
}
