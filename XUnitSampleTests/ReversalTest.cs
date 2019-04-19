using FluentAssertions;
using StringExtensions;
using System;
using Xunit;

namespace XUnitSampleTests
{
    public sealed class ReversalTest
    {
        [Theory]
        [InlineData("abcdef", "fedcba")]
        [InlineData("how do you do?", "?od uoy od woh")]
        [InlineData(null, null)]
        [InlineData("x", "x")]
        public void ReverseStringTest(string input, string output)
        {
            // setup
            // execute
            var result = input.Reverse();
            // aseert
            result.Should().Be(output);
        }
        [Theory]
        [InlineData("hello world", "world hello")]
        [InlineData("how do you do?", "do? you do how")]
        [InlineData(null, null)]
        [InlineData("x", "x")]
        public void ReverseSentenceTest(string input, string output)
        {
            // setup
            // execute
            var result = input.ReverseSentence();
            // aseert
            result.Should().Be(output);

        }
    }
}
