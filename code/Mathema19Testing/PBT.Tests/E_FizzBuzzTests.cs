using System;
using FsCheck;
using FsCheck.Xunit;

namespace PBT.Tests
{
    // https://www.pluralsight.com/tech-blog/property-based-tdd
    public class E_FizzBuzzTests
    {
        // Step 1
        [Property]
        public Property Anything_divisible_by_three_but_not_five_returns_fizz(int input)
        {
            Func<bool> property = () => Fizz.Buzz(input) == "Fizz";

            return property.When(input % 3 == 0 && input % 5 != 0);
        }

        //// Step 2
        //[Property]
        //public Property Anything_divisible_by_five_but_not_three_returns_buzz(int input)
        //{
        //    Func<bool> property = () => Fizz.Buzz(input) == "Buzz";

        //    return property.When(input % 5 == 0 && input % 3 != 0);
        //}

        //// Step 3
        //// Fails!
        //[Property]
        //public Property Anything_divisible_by_three_and_five_returns_fizzbuzz(int input)
        //{
        //    Func<bool> property = () => Fizz.Buzz(input) == "FizzBuzz";

        //    return property.When(input % 3 == 0 && input % 5 == 0);
        //}

        //// Step 4
        //// Fails!
        //[Property(Arbitrary = new []{typeof(FizzBuzzGenerator)})]
        //public Property Anything_divisible_by_three_and_five_returns_fizzbuzz_with_arbitrary(int input)
        //{
        //    Func<bool> property = () => Fizz.Buzz(input) == "FizzBuzz";

        //    return property.When(input % 3 == 0 && input % 5 == 0);
        //}

        //// Step 5
        //// Fails
        //[Property]
        //public Property Anything_not_divisible_by_three_and_five_should_return_value_as_string(int input)
        //{
        //    Func<bool> property = () => Fizz.Buzz(input) == input.ToString();

        //    return property.When(input % 3 != 0 && input % 5 != 0);
        //}

        //// Step 6
        //// Fails
        //[Property]
        //public Property Anything_not_divisible_by_three_and_five_should_return_value_as_string_2(int input)
        //{
        //    Func<bool> property = () => Fizz.Buzz(input) == input.ToString();

        //    return property.When(input % 3 != 0 && input % 5 != 0).Label($"Failed on input {input}");
        //}

    }

    public class Fizz
    {
        // Step 1
        public static string Buzz(int input) => "Fizz";

        // Step 2
        //public static string Buzz(int input) => input % 5 == 0 ? "Buzz" : "Fizz";

        // Step 3
        //public static string Buzz(int input)
        //{
        //    var output = "";

        //    if (input % 3 == 0) output += "Fizz";
        //    if (input % 5 == 0) output += "Buzz";

        //    return output;
        //}

        // Step 6
        //public static string Buzz(int input)
        //{
        //    var output = "";

        //    if (input % 3 == 0) output += "Fizz";
        //    if (input % 5 == 0) output += "Buzz";

        //    return string.IsNullOrEmpty(output) ? input.ToString() : output;
        //}
    }
}