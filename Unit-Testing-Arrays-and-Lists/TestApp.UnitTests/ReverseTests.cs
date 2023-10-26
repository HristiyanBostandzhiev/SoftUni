using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] arr = { 100 }; 

        // Act
        string result = Reverse.ReverseArray(arr);

        // Assert
        Assert.That(result, Is.EqualTo("100"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        int[] arr = { 100, 99, 1 };
        string result = Reverse.ReverseArray(arr);
        Assert.That (result, Is.EqualTo("1 99 100"));
    }
}
