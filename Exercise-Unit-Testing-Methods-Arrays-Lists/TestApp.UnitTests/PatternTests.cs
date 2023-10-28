using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? input = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] number = { 1, 10, 10, 20, 55, 100, 90, 1, 20 };
        int[] actual = Pattern.SortInPattern(number);
        Assert.That(actual, Is.EqualTo(new int[] { 1, 100, 10, 90, 20, 55 }));

    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] number = { };
        int[] actual = Pattern.SortInPattern(number);
        Assert.That(actual, Is.EqualTo(new int[] { }));
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] number = { 69};
        int[] actual = Pattern.SortInPattern(number);
        Assert.That(actual, Is.EqualTo(new int[] { 69}));
    }
}
