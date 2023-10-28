using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        long input = 0;
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long input = 7;
        long actual = PrimeFactor.FindLargestPrimeFactor(input);
        Assert.That(actual, Is.EqualTo(7));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long input = 1000;
        long actual = PrimeFactor.FindLargestPrimeFactor(input);
        Assert.That(actual, Is.EqualTo(5));
    }
}
