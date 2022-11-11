namespace Test.SearchAlgos;

public class Linear
{
    /// <summary>
    /// Linear Search Algorithm.
    /// Return the index of the target value if found.
    /// Runtime: O(n)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int Search(int[] arr, int target)
    {
        // Loop through the array
        for (int i = 0; i < arr.Length; i++)
        {
            // If the current element is equal to the target
            if (arr[i] == target)
            {
                // Return the index
                return i;
            }
        }

        // Return -1 if the target is not found
        return -1;
    }

}
