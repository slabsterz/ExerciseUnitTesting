using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "aha", "ehe" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> input = new();

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "aha" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        List<string> input = new() { "cat", "dog" };

        bool result = Palindrome.IsPalindrome(input);

        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedInput_ReturnsFalse()
    {
        List<string> input = new() { "cat", "dog" , "aha" };

        bool result = Palindrome.IsPalindrome(input);

        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        List<string> input = new() { "!aha!" };

        bool result = Palindrome.IsPalindrome(input);

        Assert.IsTrue(result);
    }
}
