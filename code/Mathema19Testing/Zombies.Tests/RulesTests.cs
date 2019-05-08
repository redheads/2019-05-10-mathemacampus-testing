using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Zombies.Tests
{
    public class RulesTests
    {
        private readonly Rules _sut;
        
        public RulesTests() => _sut = new Rules();

        // Include each `InlineData` line one by one, run `dotnet stryker` and see how it changes the outcome.
        [Theory]
        [InlineData("a", true)]             // -> 3 survive
        // [InlineData("", false)]             // -> 2 survive
        // [InlineData(null, false)]           // -> 2 survive
        // [InlineData("123", true)]           // -> 1 survives
        // [InlineData("1234", false)]         // -> 0 survive
        public void ValidationRule_works(string input, bool expected) => 
            _sut.Validate(input).Should().Be(expected);

        [Theory]
        [InlineData(5, 5, true)]    // addition
        // [InlineData(15, 5, true)]   // subtraction
        // [InlineData(2, 5, true)]    // multiplication
        // [InlineData(20, 2, true)]   // division
        // [InlineData(5, 4, true)]    // modulo
        // [InlineData(1, 1, false)]   // other combinations
        public void AnotherValidation_works(int a, int b, bool expected) =>
            _sut.AnotherValidation(a, b).Should().Be(expected);

        [Theory]
        [InlineData(3, 3)]
        public void Looping_works(int input, int expected) =>
            _sut.Looping(input).Should().Be(expected);
        
        [Theory]
        [InlineData(true, true, true)]
        // [InlineData(true, false, true)]
        // [InlineData(false, true, true)]
        // [InlineData(false, false, false)]
        public void Logical_works(bool a, bool b, bool expected) =>
            _sut.Logical(a, b).Should().Be(expected);

        // https://github.com/stryker-mutator/stryker-handbook/blob/master/mutator-types.md#method-expression
        [Theory]
        [MemberData(nameof(GetFirstData), 1)]   // list with length 1: First() == Last()
        // [MemberData(nameof(GetFirstData), 2)]   // list with 2 different entries
        public void GetFirst_works(IEnumerable<int> collection, int expected) =>
            _sut.GetFirst(collection).Should().Be(expected);

        public static IEnumerable<object[]> GetFirstData(int numberOfTests)
        {
            var allData = new List<object[]>
            {
                new object[] {new List<int> {1}, 1},
                new object[] {new List<int> {1, 2}, 1},
            };
            
            return allData.Take(numberOfTests);
        }
    }
}
