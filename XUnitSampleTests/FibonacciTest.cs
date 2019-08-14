using Xunit;
using FluentAssertions;
using Fibonacci;
using System.Linq;

namespace XUnitSampleTests
{
    public sealed class FibonacciTest
    {
        // see https://planetmath.org/listoffibonaccinumbers
        private readonly FibonacciFactory _fibonacciFactory = new FibonacciFactory();
        
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(9, 34)]
        [InlineData(10, 55)]
        [InlineData(63, 6557470319842)]
        public void VariousFibonaccis(int cardinality, long value)
        {
            // setup
            _fibonacciFactory.Append<long>(value);
            // execute
            var result = _fibonacciFactory.Take(cardinality).Last();
            // assert
            result.Should().Be(value);
        }
    }
}
