using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> oneElement = new List<int>() { 69 };

        // Act
        List<int> result = GaussTrick.SumPairs(oneElement);

        // Assert
        CollectionAssert.AreEqual(oneElement, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenElements = new List<int>() { 1, 2, 3, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(evenElements);
        List<int> expected = new List<int>() { 5 ,5}; 

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> oddElements = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> result = GaussTrick.SumPairs(oddElements);
        List<int> expected = new List<int>() { 6, 6, 3};
        Assert.That (result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        List<int> largeOddElements = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        List<int> result = GaussTrick.SumPairs(largeOddElements);
        List<int> expected = new List<int>() { 21, 21, 21, 21, 21, 21, 21, 21, 21, 21 };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> largeEvenElements = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
        List<int> result = GaussTrick.SumPairs(largeEvenElements);
        List<int> expected = new List<int>() { 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 11 };
        Assert.That(result, Is.EqualTo(expected));
    }
}
