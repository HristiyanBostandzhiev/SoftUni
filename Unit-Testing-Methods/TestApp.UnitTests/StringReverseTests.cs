using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        string input = "";
        StringReverse.Reverse(input);
        Assert.AreEqual(string.Empty, input);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        string input = "M";
        StringReverse.Reverse(input);
        Assert.AreEqual("M", input);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = "abc";
        string expected = StringReverse.Reverse(input);
        Assert.That("cba", Is.EqualTo(expected));
    }
}
