using Test.SearchAlgos;
using Test.SortingAlgos;

// An array with random integers
int[] unsortedArray = new int[] { 5, 10, 2, 3, 25, 18, 19, 20, 21, 11, 1, 6, 7, 16, 17, 12, 13, 14, 15, 23, 24, 8, 9, 4, 22 };
int valueToFind = 17;    // The value to find in the array   // Must exist in the unsortedArray!

// Sort the array
var sortedArray = Quick.Sort(arr:unsortedArray);
// var sortedArray = Insertion.Sort(unsortedArray);     // Alternate sorting algo.

// Save original position of the value to find
int itemOriginalPosition = Array.IndexOf(unsortedArray, valueToFind);

// Print the sorted array
sortedArray.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine();

// Outputs: ((Prints -1 if the value is not found))
Console.WriteLine($"Item with value {valueToFind} is in position: {Binary.Search(arr:sortedArray, target:valueToFind)}");
Console.WriteLine($"Items original position was: {itemOriginalPosition}");

// Hold console window open.
Console.ReadKey();
