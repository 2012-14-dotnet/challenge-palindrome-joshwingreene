using Palindrome.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_IsPalindrome()
        {
            // arrange
            var sut = new PalindromeChecker("Sore was I ere I saw Eros"); // inference

            // act
            var actual = sut;

            // assert
            Assert.True(actual.CheckIfPalindrome().Equals(true));
        }
    }
}