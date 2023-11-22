using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInput()
    {
        // Arrange
        int n = -1;

        // Act & Assert
        Assert.That(() => Fibonacci.CalculateFibonacci(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        int input = 0;
        int result = Fibonacci.CalculateFibonacci(input);
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int input = 12;
        int result = Fibonacci.CalculateFibonacci(input);
        int expected = 144;
        Assert.That(expected, Is.EqualTo(result));

    }
}