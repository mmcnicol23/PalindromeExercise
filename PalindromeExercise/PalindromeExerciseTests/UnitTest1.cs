using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("tacocat", true)]
        [InlineData("abcdefg", false)]
        [InlineData("kayak", true)]
        [InlineData("mariah", false)]
        public void TestIsAPalindrome(string myString, bool expected)
        {
            //Arrange
            var wordsmith = new WordSmith();
            
            //Act
            var actual = wordsmith.IsAPalindrome(myString);
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
