using System;
using System.Linq;
using FsCheck;
using FsCheck.Xunit;

namespace PBT.Tests
{
    public class F_StringReverseTests
    {
        public static string Reverse(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //[Property]
        [NonEmptyString]
        public Property Input_should_have_same_length_as_output(string input) 
            => (Reverse(input).Length == input.Length).ToProperty();

        [NonEmptyString]
        public Property Invoking_reverse_twice_returns_original_input(string input)
            => (Reverse(Reverse(input)) == input).ToProperty();

        [NonEmptyString]
        public Property First_string_input_is_last_string_output(string input)
            => (Reverse(input).Last() == input.First()).ToProperty();
        
        [NonEmptyString]
        public Property Prepending_and_reversing_is_equal_to_reversing_and_appending(string input)
            => (Reverse("x" + input) == Reverse(input) + "x").ToProperty();

        public static class NonEmptyStringArbitrary
        {
            public static Arbitrary<string> Strings() => 
                Arb.Default.String()
                    .Filter(x => x != null && !string.IsNullOrWhiteSpace(x));
        }

        public class NonEmptyStringAttribute : PropertyAttribute
        {
            public NonEmptyStringAttribute() => 
                Arbitrary = new[] {typeof(NonEmptyStringArbitrary)};
        }
    }
}