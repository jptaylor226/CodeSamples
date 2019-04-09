using FluentAssertions;
using NUnit.Framework;
using RomanNumerals;

namespace SampleTests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        private static readonly INumeralsParser _sut = new RomanNumeralsParser();

        [TestCase(null, 0)]
        [TestCase("", 0)]
        [TestCase("    ", 0)]
        [TestCase("not a number", 0)]
        [TestCase("VI", 6)]
        [TestCase("VIII", 8)]
        [TestCase("XV", 15)]
        [TestCase("CLX", 160)]
        [TestCase("CCVII", 207)]
        [TestCase("MLXVI", 1066)]
        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("IL", 49)]
        [TestCase("XC", 90)]
        [TestCase("CM", 900)]
        [TestCase("XXXIX", 39)]
        [TestCase("CCXLVI", 246)]
        [TestCase("CDXXI", 421)]
        [TestCase("MDCCLXXVI", 1776)]
        [TestCase("MCMLIV", 1954)]
        [TestCase("MCMXC", 1990)]
        public void ParseTest(string input, int value)
        {
            // setup
            // execute
            var result = _sut.Value(input);
            // assert
            result.Should().Be(value);
        }
    }
}