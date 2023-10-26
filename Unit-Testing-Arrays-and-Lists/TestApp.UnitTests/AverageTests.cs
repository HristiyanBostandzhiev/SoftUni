using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Average.CalculateAverage(emptyArray));
       
    }

    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        int[] arr = { 1, 2, 3, 4 };
        double result = Average.CalculateAverage(arr);
        Assert.That(result, Is.EqualTo(2.5));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        int[] arr = { -5, -10};
        double result = Average.CalculateAverage(arr);
        Assert.That(result, Is.EqualTo(-7.5));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        int[] arr = { 1, -2, 3, 4, -1 };
        double result = Average.CalculateAverage(arr);
        Assert.That(result, Is.EqualTo(1));
    }
}
