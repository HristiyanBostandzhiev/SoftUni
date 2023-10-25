using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        int input = 0;
        int actual = Factorial.CalculateFactorial(input);
        Assert.AreEqual(1, actual);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        int input = 6;
        int actual = Factorial.CalculateFactorial(input);
        Assert.AreEqual(720, actual);
    }

    [Test]
    public void Test_CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        int input = -85;
        Assert.Throws<ArgumentOutOfRangeException>(() => Factorial.CalculateFactorial(input));
    }
}
