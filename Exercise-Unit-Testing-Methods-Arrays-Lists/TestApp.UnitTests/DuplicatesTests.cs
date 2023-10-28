using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.AreEqual(0, actual.Length);
    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] nums = new int[] { 1, 2, 3 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(nums);

        // Assert
        Assert.That(actual, Is.EqualTo(nums));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        int[] nums = new int[] { 10, 20, 30, 30, 50, 69, 30, 10, 20 };
        int[] actual = Duplicates.RemoveDuplicates(nums);
        int[] expected = new int[] { 10, 20, 30, 50, 69 };
        Assert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] nums = { 1, 1, 1, 1, 1 };
        int[] actual = Duplicates.RemoveDuplicates(nums);
        Assert.That(actual, Is.EqualTo(new int[] { 1 }));

    }
}
