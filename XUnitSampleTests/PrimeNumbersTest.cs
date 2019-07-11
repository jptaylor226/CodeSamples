using System;
using System.Linq;
using PrimeNumbers;
using Xunit;
using FluentAssertions;

namespace XUnitSampleTests
{
    public sealed class PrimeNumbersTest
    {
        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        [InlineData(11, true)]
        [InlineData(13, true)]
        [InlineData(17, true)]
        [InlineData(19, true)]
        [InlineData(23, true)]
        [InlineData(29, true)]
        [InlineData(31, true)]
        [InlineData(37, true)]
        [InlineData(41, true)]
        [InlineData(43, true)]
        [InlineData(47, true)]
        [InlineData(53, true)]
        [InlineData(59, true)]
        [InlineData(61, true)]
        [InlineData(67, true)]
        [InlineData(71, true)]
        [InlineData(73, true)]
        [InlineData(79, true)]
        [InlineData(83, true)]
        [InlineData(89, true)]
        [InlineData(97, true)]
        [InlineData(101, true)]
        [InlineData(103, true)]
        [InlineData(107, true)]
        [InlineData(109, true)]
        [InlineData(113, true)]
        [InlineData(127, true)]
        [InlineData(131, true)]
        [InlineData(137, true)]
        [InlineData(139, true)]
        [InlineData(149, true)]
        [InlineData(151, true)]
        [InlineData(157, true)]
        [InlineData(163, true)]
        [InlineData(167, true)]
        [InlineData(173, true)]
        [InlineData(179, true)]
        [InlineData(181, true)]
        [InlineData(191, true)]
        [InlineData(193, true)]
        [InlineData(197, true)]
        [InlineData(199, true)]
        [InlineData(211, true)]
        [InlineData(223, true)]
        [InlineData(227, true)]
        [InlineData(229, true)]
        [InlineData(233, true)]
        [InlineData(239, true)]
        [InlineData(241, true)]
        [InlineData(251, true)]
        [InlineData(257, true)]
        [InlineData(263, true)]
        [InlineData(269, true)]
        [InlineData(271, true)]
        [InlineData(277, true)]
        [InlineData(281, true)]
        [InlineData(283, true)]
        [InlineData(293, true)]
        [InlineData(307, true)]
        [InlineData(311, true)]
        [InlineData(313, true)]
        [InlineData(317, true)]
        [InlineData(331, true)]
        [InlineData(337, true)]
        [InlineData(347, true)]
        [InlineData(349, true)]
        [InlineData(353, true)]
        [InlineData(359, true)]
        [InlineData(367, true)]
        [InlineData(373, true)]
        [InlineData(379, true)]
        [InlineData(383, true)]
        [InlineData(389, true)]
        [InlineData(397, true)]
        [InlineData(401, true)]
        [InlineData(409, true)]
        [InlineData(419, true)]
        [InlineData(421, true)]
        [InlineData(431, true)]
        [InlineData(433, true)]
        [InlineData(439, true)]
        [InlineData(443, true)]
        [InlineData(449, true)]
        [InlineData(457, true)]
        [InlineData(461, true)]
        [InlineData(463, true)]
        [InlineData(467, true)]
        [InlineData(479, true)]
        [InlineData(487, true)]
        [InlineData(491, true)]
        [InlineData(499, true)]
        [InlineData(503, true)]
        [InlineData(509, true)]
        [InlineData(521, true)]
        [InlineData(523, true)]
        [InlineData(541, true)]
        [InlineData(547, true)]
        [InlineData(557, true)]
        [InlineData(563, true)]
        [InlineData(569, true)]
        [InlineData(571, true)]
        [InlineData(577, true)]
        [InlineData(587, true)]
        [InlineData(593, true)]
        [InlineData(599, true)]
        [InlineData(601, true)]
        [InlineData(607, true)]
        [InlineData(613, true)]
        [InlineData(617, true)]
        [InlineData(619, true)]
        [InlineData(631, true)]
        [InlineData(641, true)]
        [InlineData(643, true)]
        [InlineData(647, true)]
        [InlineData(653, true)]
        [InlineData(659, true)]
        [InlineData(661, true)]
        [InlineData(673, true)]
        [InlineData(677, true)]
        [InlineData(683, true)]
        [InlineData(691, true)]
        [InlineData(701, true)]
        [InlineData(709, true)]
        [InlineData(719, true)]
        [InlineData(727, true)]
        [InlineData(733, true)]
        [InlineData(739, true)]
        [InlineData(743, true)]
        [InlineData(751, true)]
        [InlineData(757, true)]
        [InlineData(761, true)]
        [InlineData(769, true)]
        [InlineData(773, true)]
        [InlineData(787, true)]
        [InlineData(797, true)]
        [InlineData(809, true)]
        [InlineData(811, true)]
        [InlineData(821, true)]
        [InlineData(823, true)]
        [InlineData(827, true)]
        [InlineData(829, true)]
        [InlineData(839, true)]
        [InlineData(853, true)]
        [InlineData(857, true)]
        [InlineData(859, true)]
        [InlineData(863, true)]
        [InlineData(877, true)]
        [InlineData(881, true)]
        [InlineData(883, true)]
        [InlineData(887, true)]
        [InlineData(907, true)]
        [InlineData(911, true)]
        [InlineData(919, true)]
        [InlineData(929, true)]
        [InlineData(937, true)]
        [InlineData(941, true)]
        [InlineData(947, true)]
        [InlineData(953, true)]
        [InlineData(967, true)]
        [InlineData(971, true)]
        [InlineData(977, true)]
        [InlineData(983, true)]
        [InlineData(991, true)]
        [InlineData(997, true)]
        [InlineData(int.MinValue, false)]
        [InlineData(int.MaxValue, true)]
        [InlineData(32452867, true)]
        [InlineData(49979687, true)]
        [InlineData((long)32452867 * (long)49979687, false)]
        [InlineData((long)49979687 * (long)49979687, false)]
        [InlineData(982451653, true)]
        [InlineData(long.MaxValue, false)]
        [InlineData(long.MaxValue - 24, true)]
        [InlineData(961, false)]
        [InlineData(899, false)]
        // Source: https://primes.utm.edu/lists/2small/0bit.html
        public void IsPrimeTest(long value, bool isPrime)
        {
            // setup
            // execute
            var result = value.IsPrime();
            // assert
            result.Should().Be(isPrime);
        }

        [Fact]
        public void BigLongPrimeTest()
        {
            // setup
            var value = long.MaxValue - 24;
            // execute
            var result = value.Factors().ToList();
            // assert
            result.Count.Should().Be(2);
            result.First().Should().Be(1);
            result.Last().Should().Be(value);
        }
        [Fact]
        public void BigLongCompositeTest()
        {
            // setup
            var prime = 49979687;
            var value = (long)prime * prime;
            // execute
            var result = value.Factors().ToList();
            // assert
            result.Count.Should().Be(3);
            result.First().Should().Be(1);
            result[1].Should().Be(prime);
            result.Last().Should().Be(value);
        }
        [Theory]
        [InlineData(360, new long[] {  1, 2, 3, 4, 5, 6, 8, 9, 10, 12, 15,
                                      18, 20, 24, 30, 36, 40, 45, 60, 72, 90,
                                     120, 180, 360})]
        [InlineData(121, new long[] {  1, 11, 121})]
        [InlineData((long)49979687 * (long)49979687, new long[] { 1, 49979687, 2497969112617969 })]
        public void FactorsTest(long value, long[] output)
        {
            // setup
            // execute
            var result = value.Factors().ToList();
            // assert
            result.Should().BeEquivalentTo(output);
        }
    }
}
