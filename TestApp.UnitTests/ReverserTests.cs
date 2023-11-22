using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] input = new string[] { "Mouse" };
        string[] expected = new string[] { "esuoM" };

        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
       CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] input = new string[] { "Mouse", "Cat", "Fox" };
        string[] expected = new string[] { "esuoM", "taC", "xoF" };

        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] input = new string[] { "Mouse!", "Cat?", "Fox$" };
        string[] expected = new string[] { "!esuoM", "?taC", "$xoF" };

        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
