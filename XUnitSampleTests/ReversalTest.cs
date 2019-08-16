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
        [Theory]
        [InlineData(null, null)]
        [InlineData(new[] { 2, 3, 5, 7 }, new[] { 7, 5, 3, 2 })]
        [InlineData(new[] { 3 }, new[] { 3 })]
        [InlineData(new int[] { }, new int[] { })]
        public void ReverseArrayTest(int[] input, int[] output)
        {
            // setup
            // execute
            var result = input.Reverse();
            // aseert
            result.Should().BeEquivalentTo(output);
        }
    }
}
