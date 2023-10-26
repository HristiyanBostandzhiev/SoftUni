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


        // Act

        // Assert
        //Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // TODO: finish test
    }
}
