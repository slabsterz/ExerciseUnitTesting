using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new() { 9, 49, 81 };
        List<double> expected = new() { 3, 7, 9 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);
        
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

   
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(result, input);
    }

    [Test]
    public void Test_ProcessNumbers_HandleNegativeNumbers()
    {
        List<int> input = new() { 1, 2, -3 };

        Assert.That(()=> NumberProcessor.ProcessNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        List<int> input = new List<int>();

        List<double> result = NumberProcessor.ProcessNumbers(input);

        CollectionAssert.AreEqual(input, result);
    }
}
