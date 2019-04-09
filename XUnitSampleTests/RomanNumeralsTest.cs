using FluentAssertions;
using RomanNumerals;
using Xunit;

namespace XUnitSampleTests
{
    public class RomanNumeralsTest
    {
        private static readonly INumeralsParser _sut = new RomanNumeralsParser();
        /*  From the source document:
                Roman numerals typically are ordered from largest symbol to smallest in additive fashion like so:  
                •	VI = 6
                •	VIII = 8
                •	XV(X + V) = 15
                    •	CLX(C+LX) = 160
                    •	CCVII(CC+VII) = 207
                    •	MLXVI(M+LX+VI) = 1066
                However, Roman numerals also use a shorthand subtractive pattern to represent numbers like 4, 9, 49, 90, etc. like so:
                •	IV(one less than 5) = 4
                •	IX(one less than 10) = 9
                •	IL(one less than 50) = 49 [sic]
                •	XC(10 less than 100) = 90
                •	CM(100 less than 1000) = 900
                Here are some more examples:
                •	XXXIX(XXX+IX) = 39
                    •	CCXLVI(CC+XL+VI) = 246
                •	CDXXI(CD+XX+I) = 421
                •	MDCCLXXVI(M+DCC+LXX+VI)  = 1776
                •	MCMLIV(M+CM+L+IV)  = 1954
                •	MCMXC(M+CM+XC)  = 1990
        */
        [Theory]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        [InlineData("    ", 0)]
        [InlineData("not a number", 0)]
        [InlineData("VI",6)]
        [InlineData("VIII", 8)]
        [InlineData("XV", 15)]
        [InlineData("CLX", 160)]
        [InlineData("CCVII", 207)]
        [InlineData("MLXVI", 1066)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("IL", 49)]
        [InlineData("XC", 90)]
        [InlineData("CM", 900)]
        [InlineData("XXXIX", 39)]
        [InlineData("CCXLVI", 246)]
        [InlineData("CDXXI", 421)]
        [InlineData("MDCCLXXVI", 1776)]
        [InlineData("MCMLIV", 1954)]
        [InlineData("MCMXC", 1990)]
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
