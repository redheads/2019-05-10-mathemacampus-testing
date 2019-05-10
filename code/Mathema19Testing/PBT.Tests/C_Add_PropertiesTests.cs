using FsCheck;
using FsCheck.Xunit;

namespace PBT.Tests
{
    // https://www.codit.eu/blog/property-based-testing-with-c/
    public class C_Add_PropertiesTests
    {
        // NOTE: Return type is "Property"!
        [Property]
        public Property Multiply_with_2_is_the_same_as_adding_the_same_number(int x)
        {
            return (x * 2 == Add(x, x)).ToProperty();
        }

        [Property]
        public Property Adding_1_twice_is_the_same_as_adding_two(int x)
        {
            return (Add(1, Add(1, x)) == Add(x, 2)).ToProperty();
        }

        [Property]
        public Property Adding_two_numbers_doesnt_depend_on_parameter_order(int x, int y)
        {
            return (Add(x, y) == Add(y, x)).ToProperty();
        }
        
        private int Add(int x, int y)
        {
            return x + y;
        }

    }
}