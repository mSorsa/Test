using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.SortingAlgos;
using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using System.Text;
using System.Threading.Tasks;


namespace Test.SortingAlgos.Tests
{
    [TestClass]
    public class CountingSortTests
    {
        [TestMethod]
        public void TestCountingSortNull()
        {
            // Assert that an exception is thrown when the input array is null
            Assert.ThrowsException<ArgumentNullException>(() => Counting.Sort(null));
        }

        [DataTestMethod]
        [DataRow(new int[] { 2, 5, 3, 1, 4 })]
        [DataRow(new int[] { 10, 5, 3, 2, 7, 4, 1, 8, 9, 6 })]
        [DataRow(new int[] { 8, 8, 8, 8, 8, 8, 8, 8 })]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void TestCountingSort(int[] arr)
        {
            // Clone the input array so we can compare the original and sorted versions
            int[] original = (int[])arr.Clone();

            // Sort the array using counting sort
            arr = Counting.Sort(arr);

            // Assert that the array is now sorted in ascending order
            CollectionAssert.AreNotEqual(arr, original);
            CollectionAssert.AreEqual(arr, original.OrderBy(x => x).ToArray());
            Assert.IsTrue(arr.OrderBy(x => x).SequenceEqual(original.OrderBy(x => x)));
        }

        [TestMethod]
        public void TestRandomizedInput()
        {
            // Generate a random array of integers
            Random random = new Random();
            int[] arr = Enumerable.Range(1, 1000).OrderBy(x => random.Next()).ToArray();

            // Clone the input array so we can compare the original and sorted versions
            int[] original = (int[])arr.Clone();

            // Sort the array using counting sort
            arr = Counting.Sort(arr);

            // Assert that the array is now sorted in ascending order
            CollectionAssert.AreNotEqual(arr, original);
            CollectionAssert.AreEqual(arr, original.OrderBy(x => x).ToArray());
            Assert.IsTrue(arr.OrderBy(x => x).SequenceEqual(original.OrderBy(x => x)));
        }

        [TestMethod]
        public void TestArrayIsSorted()
        {
            int[] arr = { 1, 2, 2, 3, 4 };
            int[] original = { 1, 2, 3, 4, 2 };

            CollectionAssert.AreNotEqual(arr, original);
            CollectionAssert.AreEqual(arr, original.OrderBy(x => x).ToArray());
            Assert.IsTrue(arr.OrderBy(x => x).SequenceEqual(original.OrderBy(x => x)));
        }
    }
}