namespace Test;

internal class Insertion
{
    /// <summary>
    /// Insertion sort algorithm.
    /// Runtime: O(n^2)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    internal static int[] Sort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int j = i;
            while (j > 0 && arr[j - 1] > arr[j])
            {
                int temp = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = temp;
                j--;
            }
        }
        return arr;
    }
}
