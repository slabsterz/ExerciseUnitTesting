using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsTrue(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        string input = "test@test@test.com";
        bool isValidEmail = Email.IsValidEmail(input);
        Assert.IsFalse(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        string? input = null;
        bool isValidEmail = Email.IsValidEmail(input);
        Assert.IsFalse(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_EmptyInput()
    {
        string input = " ";
        bool isValidEmail = Email.IsValidEmail(input);
        Assert.IsFalse(isValidEmail);
    }
}
