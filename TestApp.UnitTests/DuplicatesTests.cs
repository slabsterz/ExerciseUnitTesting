using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
   
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        CollectionAssert.AreEqual(result, numbers);
    }

   
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(input);

        // Assert
        CollectionAssert.AreEqual(result, input);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        int[] input = new int[] {1, 1, 2, 3, 3, 4};
        int[] expected = new int[] { 2, 4 };

        int[] result = Duplicates.RemoveDuplicates(expected);
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] input = new int[] { 1, 1, 1, 1, 1, 1 };
        int[] expected = new int[] { 1 };

        int[] result = Duplicates.RemoveDuplicates(expected);
        CollectionAssert.AreEqual(result, expected);
    }
}
