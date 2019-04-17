using FluentAssertions;
using Hanoi;
using System.Linq;
using Xunit;

namespace XUnitSampleTests
{
    public sealed class HanoiTest
    {
        private readonly Monastery _monastery = new Monastery();
        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 3)]
        [InlineData(3, 7)]
        [InlineData(4, 15)]
        [InlineData(5, 31)]
        [InlineData(6, 63)]
        [InlineData(7, 127)]
        [InlineData(8, 255)]
        [InlineData(9, 511)]
        [InlineData(10, 1023)]
        public void OneKMoves(short discs, int moves)
        {
            // setup
            // execute
            _monastery.MoveDisks(discs, PegLocation.A, PegLocation.B);
            // assert
            _monastery.Moves.Count().Should().Be(moves);
        }
        [Fact]
        public void MegaMoves()
        {
            // setup
            // execute
            _monastery.MoveDisks(20, PegLocation.A, PegLocation.B);
            // assert
            _monastery.Moves.Count().Should().Be((1 << 20) -1);
        }
    }
}
