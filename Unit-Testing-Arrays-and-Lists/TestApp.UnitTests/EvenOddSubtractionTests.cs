using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNumbers = { 8, 12 };

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        int[] negativeNums = { -8, -12 };
        int result = EvenOddSubtraction.FindDifference(negativeNums);
        Assert.That (result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        int[] mixNums = { 8, -12 };
        int result = EvenOddSubtraction.FindDifference(mixNums);
        Assert.That(result, Is.EqualTo(4));
    }
}
