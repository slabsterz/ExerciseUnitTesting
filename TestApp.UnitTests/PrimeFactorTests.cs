using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [TestCase(-1)]
    [TestCase(0)]
    [TestCase(1)]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo(long input)
    {
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long input = 899;
        long expected = 31;
        long result = PrimeFactor.FindLargestPrimeFactor(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long input = 123456789123456789;
        long expected = 52579;
        long result = PrimeFactor.FindLargestPrimeFactor(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}
