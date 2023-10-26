using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MaxNumber.FindMax(nullList));
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MaxNumber.FindMax(emptyList));
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        List<int> oneElement = new List<int>() { 69 };
        int result = MaxNumber.FindMax(oneElement);
        Assert.That(result, Is.EqualTo(69));

    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> postiveInt = new List<int>() { 69, 79, 169, 869 };
        int result = MaxNumber.FindMax(postiveInt);
        Assert.That(result, Is.EqualTo(869));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> negativeInt = new List<int>() { -69, -79, -169, 869 };
        int result = MaxNumber.FindMax(negativeInt);
        Assert.That(result, Is.EqualTo(869));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> mixedInt = new List<int>() { -69, 69};
        int result = MaxNumber.FindMax(mixedInt);
        Assert.That(result, Is.EqualTo(69));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> duplicateInt = new List<int>() { 69, 69, 69, 1, 2, 2, 68, -9, -213, int.MinValue };
        int result = MaxNumber.FindMax(duplicateInt);
        Assert.That(result, Is.EqualTo(69));
    }
}
