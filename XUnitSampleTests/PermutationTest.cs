using FluentAssertions;
using StringExtensions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitSampleTests
{
    public class PermutationTest
    {
        [Theory]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        [InlineData("C", 1)]
        [InlineData("CA", 2)]
        [InlineData("CAR", 6)]
        [InlineData("CARD", 24)]
        [InlineData("CARDS", 120)]
        [InlineData("CARDIO", 720)]
        [InlineData("ABCDEFGHI", 362880)]
        public void PermuteCounts(string value, int length)
        {
            // setup
            // execute
            var result = value.Permute().ToList();
            // assert
            result.Count.Should().Be(length);
        }
        [Fact]
        public void PermuteCAR()
        {
            // setup
            var permutations = new List<string>{ "CAR", "CRA", "ACR", "ARC", "RCA", "RAC" };
            // execute
            var result = "CAR".Permute().ToList();
            // assert
            permutations.All(_ => result.Contains(_)).Should().BeTrue();
        }
        [Fact]
        public void PermuteCARD()
        {
            // setup
            var permutations = new List<string>
            {
                "CARD", "CADR", "CRAD", "CRDA", "CDAR", "CDRA",
                "ACRD", "ACDR", "ARCD", "ARDC", "ADCR", "ADRC",
                "RCAD", "RCDA", "RACD", "RADC", "RDCA", "RDAC",
                "DCAR", "DCRA", "DACR", "DARC", "DRCA", "DRAC"
            };
            // execute
            var result = "CARD".Permute().ToList();
            // assert
            permutations.All(_ => result.Contains(_)).Should().BeTrue();
        }
    }
}
