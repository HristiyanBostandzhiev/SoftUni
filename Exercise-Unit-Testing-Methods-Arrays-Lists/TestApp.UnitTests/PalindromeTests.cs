using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new () { "racecar", "level" };

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        bool actual = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        List<string> input = new () { "rotor" };
        bool actual = Palindrome.IsPalindrome(input);
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        List<string> input = new() { "dog" };
        bool actual = Palindrome.IsPalindrome(input);
        Assert.IsFalse(actual);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        List<string> input = new() { "MaDaM", "TenEt" };
        bool actual = Palindrome.IsPalindrome(input);
        Assert.IsTrue(actual);
    }
}
