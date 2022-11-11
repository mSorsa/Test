namespace Test.SearchAlgos.Tests;

[TestClass()]
public class LinearTests
{
    [TestMethod()]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(8)]
    [DataRow(10)]
    public void LinearSearchTest_Valid(int target)
    {
        // Arrange
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Act
        int actual = arr.Select(x => x).ToList().IndexOf(target);
        int result = Linear.Search(arr, target);

        // Assert
        Assert.AreEqual(actual, result);
    }

    [TestMethod]
    [DataRow(110)]
    [DataRow(120)]
    [DataRow(3)]
    [DataRow(-14)]
    [DataRow(-12)]
    public void LinearSearchTest_Invalid(int target)  // not existing in array
    {
        // Arrange
        int[] arr = { -4, -3, -2, -1, 0, 1, 2, /* 3, */ 4, 5, 6, 7, 8, 9, 10 };
        
        // Act
        int result = Linear.Search(arr, target);

        // Assert
        Assert.AreEqual(-1, result); // -1 is returned for all invalid searches
    }
}