namespace Test.SearchAlgos;

public class Binary
{
    /// <summary>
    /// Binary search algorithm.
    /// Assume array is sorted.
    /// Return index of target value if found.
    /// Runtime: O(log n)
    /// </summary>
    /// <param name="arr">Sorted array.</param>
    /// <param name="target">Target value to be found.</param>
    /// <returns>Returns the index in the array where target is found. Else returns -1.</returns>
    public static int Search(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        
        // While there are still 'nodes' to check...
        while (left <= right)
        {
            // Get the middle index
            int mid = (left + right) / 2;
            
            // If the target is equal to the middle element
            if (arr[mid] == target)
            {
                // return the index
                return mid;
            }
            // If the target is greater than the middle element
            else if (arr[mid] < target)
            {
                // Check the values to the right of the middle (upper half of array)
                left = mid + 1;
            }
            // If the target is less than the target
            else
            {
                // Check the values on the left of the middle (lower half of array)
                right = mid - 1;
            }
        }
        
        // Return -1 if the target is not found
        return -1;
    }
}
