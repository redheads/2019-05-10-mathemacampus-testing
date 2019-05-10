using FluentAssertions;
using FsCheck.Xunit;

namespace PBT.Tests
{
    public class B_Intro_PropertyBasedTests
    {
        // show in debugger
        // - "a" can change!
        [Property(Verbose = true)]
        public void Generating_stuff(int a)
        {
            true.Should().BeTrue();
        }

        // show in debugger
        [Property]
        public void Generating_stuff_can_fail(int someNumber)
        {
            someNumber.Should().BeGreaterThan(-11);
        }
    }
}