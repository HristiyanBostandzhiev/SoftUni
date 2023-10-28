using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] input = { 'a', 'b', '2' };
        char[] actual = Fake.RemoveStringNumbers(input);
        Assert.That(actual, Is.EqualTo(new char[] { 'a', 'b'}));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] input = { 'n', 'm' };
        char[] actual = Fake.RemoveStringNumbers(input);
        Assert.That(actual, Is.EqualTo(new char[] { 'n', 'm' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] input = { };
        char[] actual = Fake.RemoveStringNumbers(input);
        Assert.That(actual, Is.EqualTo(new char[] { }));
    }
}
