using FluentAssertions;
using FsCheck;
using FsCheck.Xunit;

namespace PBT.Tests
{
    public class D_PropertiesWithArbitrariesTests
    {
        private int Add(int number, int otherNumber) => number + otherNumber;

        [Property]
        public void Adding_two_positive_numbers_returns_larger_number_1(int number) 
            => Add(number, number).Should().BeGreaterThan(number);

        [Property(
            Verbose = true, 
            MaxTest = 1000, 
            QuietOnSuccess = true, 
            Arbitrary = new[] { typeof(PositiveNumberArbitrary) })]
        public void Adding_two_positive_numbers_returns_larger_number(int number) 
            => Add(number, number).Should().BeGreaterThan(number);

        private static class PositiveNumberArbitrary
        {
            public static Arbitrary<int> Numbers() =>
                Arb.Default.Int32().Filter(x => x > 0);
        }
    }
}