using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] input = { "Hello" };

        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { "olleH" }));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        string[] input = { "Hello", "dersata", "atasred" };
        string[] result = Reverser.ReverseStrings(input);
        Assert.That(result, Is.EqualTo(new[] { "olleH", "atasred", "dersata" }));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        string[] input = { "!@#$%^&*()" };
        string[] result = Reverser.ReverseStrings(input);
        Assert.That(result, Is.EqualTo(new[] { ")(*&^%$#@!" }));
    }
}
