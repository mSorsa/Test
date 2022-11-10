namespace Test.SortingAlgos.Tests;

[TestClass]
public class QuickTests
{
    [TestMethod]
    [DataRow(new int[] {1, 2, 3, 4, 5})]
    public void QuickSortTest_1_Valid(int[] input)
    {
        // Arrange
        var expected = input.Clone() as int[];
        Array.Sort(expected);
        // Act
        var actual = Quick.Sort(input);
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DataRow(new int[] {2, 4, 8, 16, 1, 12})]
    public void QuickSortTest_2_Valid(int[] input)
    {
        // Arrange
        var expected = input.Clone() as int[];
        Array.Sort(expected);
        // Act
        var actual = Quick.Sort(input);
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    [DataRow(new int[] { 2, -4, 8, 16, -1, 12 })]
    public void QuickSortTest_3_Valid(int[] input)
    {
        // Arrange
        var expected = input.Clone() as int[];
        Array.Sort(expected);
        // Act
        var actual = Quick.Sort(input);
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    [DataRow(new int[] { 2, -4, 8, 16, -1, 12, 0 }, new int[] { 0, -1, 2, -4, 8, 12, 16 })]
    public void QuickSortTest_4_Invalid(int[] input, int[] wrong)
    {
        // Act
        var actual = Quick.Sort(input);
        // Assert
        CollectionAssert.AreNotEqual(wrong, actual);
    }
    
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    public void QuickSortTest_5_Invalid(int[] input, int[] wrong)
    {
        var actual = Quick.Sort(input);

        CollectionAssert.AreNotEqual(wrong, actual);
    }
}