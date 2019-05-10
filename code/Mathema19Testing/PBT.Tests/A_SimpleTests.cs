using System;
using FluentAssertions;
using Tynamix.ObjectFiller;
using Xunit;

namespace PBT.Tests
{
    public class A_SimpleTests
    {
        public int Add(int a, int b) => a + b;

        [Fact]
        public void Adding_1_and_1_returns_2() => Add(1, 1).Should().Be(2);

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(-1, 1, 0)]
        [InlineData(0, 0, 0)]
        // [InlineData(0, Int32.MaxValue, Int32.MaxValue)] // Identity property, passes
        // [InlineData(1, Int32.MaxValue, Int32.MaxValue)] // fails
        public void Adding_two_number_returns_correct_result(
            int a, int b, int expected) => 
            Add(a, b).Should().Be(expected);

        [Fact]
        public void Adding_2_random_numbers_should_work()
        {
            // Using `ObjectFiller`
            var a = Randomizer<int>.Create();
            var b = Randomizer<int>.Create();

            // Dangerous
            Add(a, b).Should().BeGreaterOrEqualTo(Int32.MinValue);
        }

    }
}