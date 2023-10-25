using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        int input = 0;
        string actual = Triangle.PrintTriangle(input);
        Assert.AreEqual(string.Empty, actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        int input = 3;
        string actual = Triangle.PrintTriangle(input);
        Assert.AreEqual("1\r\n" +
                        "1 2\r\n" +
                        "1 2 3\r\n" +
                        "1 2\r\n" +
                        "1", actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        int input = 4;
        string actual = Triangle.PrintTriangle(input);
        Assert.AreEqual("1\r\n" +
                        "1 2\r\n" +
                        "1 2 3\r\n" +
                        "1 2 3 4\r\n" +
                        "1 2 3\r\n" +
                        "1 2\r\n" +
                        "1", actual);
    }
}
