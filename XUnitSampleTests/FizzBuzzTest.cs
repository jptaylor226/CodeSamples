using FizzBuzz;
using Xunit;
using System.Linq;
using FluentAssertions;
using System;
using System.Collections.Generic;

namespace XUnitSampleTests
{
    public sealed class FizzBuzzTest
    {
        private readonly FizzBuzzFactory _sut = new FizzBuzzFactory();
        [Fact]
        public void FizzBuzzOnce()
        {
            // setup
            // execute
            var result = _sut.Take(1).ToList();
            // assert
            result.Count.Should().Be(1);
            result[0].Value.Should().Be(1);
            result[0].Parsed.Should().Be(1.ToString());
        }
        [Fact]
        public void BasicBuzz()
        {
            // setup
            // execute
            var result = _sut.Take(15).ToList();
            // assert
            result.Count.Should().Be(15);
            for (var i = 0; i < result.Count; i++)
            {
                result[i].Value.Should().Be(i + 1);
                switch (result[i].Value)
                {
                    case 1:
                    case 2:
                    case 4:
                    case 7:
                    case 8:
                    case 11:
                    case 13:
                    case 14:
                        result[i].Parsed.Should().Be($"{i + 1}");
                        break;

                    case 3:
                    case 6:
                    case 9:
                    case 12:
                        result[i].Parsed.Should().Be("Fizz");
                        break;

                    case 5:
                    case 10:
                        result[i].Parsed.Should().Be("Buzz");
                        break;

                    case 15:
                        result[i].Parsed.Should().Be("FizzBuzz");
                        break;
                }
            }
        }
        [Fact]
        public void FifthBuzz()
        {
            // setup
            // execute
            var result = _sut.Where(_ => _.Parsed.Contains("Buzz", StringComparison.CurrentCultureIgnoreCase)).Take(5).Last();
            // assert
            result.Value.Should().Be(25);
        }
        [Fact]
        public void EighthFizz()
        {
            // setup
            var sut = new FizzBuzzFactory();
            // execute
            var result = _sut.Where(_ => _.Parsed.Contains("Fizz", StringComparison.CurrentCultureIgnoreCase)).Take(8).Last();
            // assert
            result.Value.Should().Be(24);
        }
        [Fact]
        public void MultipleEnumerationOK()
        {
            // setup
            // execute
            var r1 = _sut.Take(5).Last();
            var r2 = _sut.Take(5).Last();
            // assert
            r1.Value.Should().Be(r2.Value);
            r1.Parsed.Should().Be(r2.Parsed);
        }
        [Fact]
        public void LuckyNumbers()
        {
            // setup
            _sut.SetBuzzwords(new Dictionary<int, string>
            {
                { 7, "Herp"},
                { 13, "Derp"},
                { 17, "Lerp" }
            });
            // execute
            var result = _sut.Take(7 * 13 * 17).Last();
            // assert
            result.Parsed.Should().Be("HerpDerpLerp");
        }
    }
}
