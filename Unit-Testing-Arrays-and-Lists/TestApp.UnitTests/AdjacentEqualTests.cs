using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => AdjacentEqual.Sum(nullList));
    }

    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        var actual = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> nums = new List<int>() { 1, 2, 3, 4, 5};

        // Act
        string result = AdjacentEqual.Sum(nums);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        List<int> input = new List<int>() { 3, 3, 6, 1 };
        string result = AdjacentEqual.Sum(input);
        Assert.That(result, Is.EqualTo("12 1"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        List<int> input = new List<int>() { 3, 3, 6, 12 };
        string result = AdjacentEqual.Sum(input);
        Assert.That(result, Is.EqualTo("24"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        List<int> input = new List<int>() { 2, 2, 3, 4, 4, 5, 6, 6, 6 };
        string result = AdjacentEqual.Sum(input);
        Assert.That(result, Is.EqualTo("4 3 8 5 12 6"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        List<int> input = new List<int>() { 1, 2, 6, 3, 9, 4, 4 };
        string result = AdjacentEqual.Sum(input);
        Assert.That(result, Is.EqualTo("1 2 6 3 9 8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        List<int> input = new List<int>() { 1, 2, 7, 3, 3, 10, 4 };
        string result = AdjacentEqual.Sum(input);
        Assert.That(result, Is.EqualTo("1 2 7 6 10 4"));
    }
}
