
using Xunit;

namespace CodePractice.Tests;

public class UnitTest1
{
    [Fact]
    public void GetBiggest_ReturnsLargestNumber()
    {
        // Arrange
        int[] numbers = { 12, 45, 7, 89, 23, 56 };
        int expected = 89;

        // Act
        int actual = DoSomething.GetBiggest(numbers);

        // Assert
        Assert.Equal(expected, actual);
    }
}
