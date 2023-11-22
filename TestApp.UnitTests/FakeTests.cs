using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
   
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] input = new char[] { '0', '1', 'a', 'b' };
        char[] expected = new char[] { 'a', 'b' };

        char[] result = Fake.RemoveStringNumbers(input);

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] input = new char[] { 'k', 'j', 'a', 'b' };       

        char[] result = Fake.RemoveStringNumbers(input);

        CollectionAssert.AreEqual(input, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] input = Array.Empty<char>();

        char[] result = Fake.RemoveStringNumbers(input);

        CollectionAssert.AreEqual(input, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_InputLettersAndSpecialCharacters_ReturnsSameArray()
    {
        char[] input = new char[] { 'a', 'b', '!', '?' };      

        char[] result = Fake.RemoveStringNumbers(input);

        CollectionAssert.AreEqual(input, result);
    }
}
