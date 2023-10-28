using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool actual = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(actual, Is.True);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        string invalidEmail = "notanemail";
        bool actual = Email.IsValidEmail(invalidEmail);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        string input = string.Empty;
        bool actual = Email.IsValidEmail(input);
        Assert.That(actual, Is.False);
    }
}
