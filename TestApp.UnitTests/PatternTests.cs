using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] input = new int[] { 1, 2, 1, 3, 4, 10, 12, 15 };
        int[] expected = new int[] { 1, 15, 2, 12, 3, 10, 4 };
        int[] result = Pattern.SortInPattern(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] input = Array.Empty<int>();
        int[] result = Pattern.SortInPattern(input);

        CollectionAssert.AreEqual(input, result);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] input = new int[] { 1 };
       
        int[] result = Pattern.SortInPattern(input);

        CollectionAssert.AreEqual(input, result);
    }
}
