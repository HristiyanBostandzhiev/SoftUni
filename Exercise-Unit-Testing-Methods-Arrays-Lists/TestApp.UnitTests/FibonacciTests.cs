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
        int actual = Fibonacci.CalculateFibonacci(input);
        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int input = 1;
        int actual = Fibonacci.CalculateFibonacci(input);
        Assert.That(actual, Is.EqualTo(1));
    }
}