using FluentAssertions;
using StringExtensions;
using Xunit;

namespace XUnitSampleTests
{
    public sealed class PalindromeTest
    {
        [Theory]
        [InlineData("")]
        [InlineData("RADAR")]
        [InlineData("level")]
        [InlineData("madam")]
        [InlineData("Madam, I'm Adam")]
        [InlineData("Able was I, 'ere I saw Elba")]
        [InlineData("Go hang a salami, I'm a lasagna hog!")]
        public void IdentifyPalindromes(string candidate)
        {
            // setup
            // execute
            var result = candidate.IsPalindrome();
            // assert
            result.Should().BeTrue();
        }
        [Theory]
        [InlineData(null)]
        [InlineData("levl")]
        [InlineData("mada")]
        [InlineData("Madam, I Adam")]
        [InlineData("Able was I, 'eR I saw Elba")]
        [InlineData("Go hang the sala, I'm a lasgna hog")]
        public void IdentifyNotPalindromes(string candidate)
        {
            // setup
            // execute
            var result = candidate.IsPalindrome();
            // assert
            result.Should().BeFalse();
        }
        [Theory]
        [InlineData("levEl", false)]
        [InlineData("RADAR", true)]
        [InlineData("madam", true)]
        [InlineData("Madam, I'm adaM", true)]
        [InlineData("Able was I, 'ere I saw Elba", false)]
        public void IdentifyCaseSensitivePalindromes(string candidate, bool expected)
        {
            // setup
            // execute
            var result = candidate.IsPalindrome(true);
            // assert
            result.Should().Be(expected);
        }
    }
}
