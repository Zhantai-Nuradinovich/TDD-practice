using NUnit.Framework;
using System.Linq;
using TDD;

namespace TDD.Tests
{
    /*
        Lets divide this into different steps so, we can easily write and test this.

        - Print numbers from 1 to 100
        - Print "Fizz" instead of number which is divisible by 3
        - Print "Buzz" instead of number which is divisible by 5
        - Print "FizzBuzz" instead of number which is divisible by both 3 and 5
    

        - Create a method to accept single number
        - Create test to verify supplied number within the range 1 to 100
        - Create test to verify number and return result Fizz or Buzz or FizzBuzz per above criteria
     */

    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        public string GetFizzBuzz_CorrectNumbers_ReturnsFizzBuzzOrNumber(int number)
        {
            return FizzBuzz.GetFizzOrBuzzOrNumberInRange1To100(number);
        }
        [Test]
        public void GetFizzBuzz_OutOfRangeNumbers_ThrowsArgumentException()
        {
            Assert.That(() => FizzBuzz.GetFizzOrBuzzOrNumberInRange1To100(-5), Throws.ArgumentException);
            Assert.That(() => FizzBuzz.GetFizzOrBuzzOrNumberInRange1To100(0), Throws.ArgumentException);
            Assert.That(() => FizzBuzz.GetFizzOrBuzzOrNumberInRange1To100(115), Throws.ArgumentException);
        }
    }
}
