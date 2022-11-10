namespace Test.SearchAlgos;

internal class Binary
{
    /// <summary>
    /// Binary search algorithm.
    /// Assume array is sorted.
    /// Runtime: O(log n)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    internal static int Search(int[] arr, int target)
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
