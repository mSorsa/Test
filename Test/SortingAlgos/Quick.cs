
namespace Test.SortingAlgos
{
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
                int pivotIndex = Partition(arr, leftIndex, rightIndex);
                QuickSortAlgorithm(arr, leftIndex, pivotIndex - 1);
                QuickSortAlgorithm(arr, pivotIndex + 1, rightIndex);
            }
            return arr;
        }

        private static int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            int pivot = arr[rightIndex];
            int i = leftIndex - 1;
            for (int j = leftIndex; j < rightIndex; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[rightIndex];
            arr[rightIndex] = temp2;
            return i + 1;
        }
    }
}
