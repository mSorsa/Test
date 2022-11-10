using Test.SearchAlgos;
using Test.SortingAlgos;

// An array with random integers
int[] unsortedArray = new int[] { 5, 10, 2, 3, 25, 18, 19, 20, 21, 11, 1, 6, 7, 16, 17, 12, 13, 14, 15, 23, 24, 8, 9, 4, 22 };
int valueToFind = 7;    // The value to find in the array

// Save original position of the value to find
int itemOriginalPosition = Array.IndexOf(unsortedArray, valueToFind);
// Sort the array
var sortedArray = Quick.QuickSortAlgorithm(unsortedArray, 0, unsortedArray.Length - 1);

// Print the sorted array
sortedArray.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine();

// Outputs:
Console.WriteLine($"Item with value {valueToFind} is in position: {Binary.Search(arr:sortedArray, target:valueToFind)}");
Console.WriteLine($"Items original position was: {itemOriginalPosition}");

// Hold console window open.
Console.ReadKey();
