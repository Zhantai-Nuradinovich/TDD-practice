using NUnit.Framework;
using System.Linq;
using TDD;

namespace TDD.Tests
{
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
        
        public void GetFizzBuzz_OutOfRangeNumbers_ThrowsArgumentException()
        {
            Assert.That(() => FizzBuzz.GetFizzOrBuzzOrNumberInRange1To100(-5), Throws.ArgumentException);
            Assert.That(() => FizzBuzz.GetFizzOrBuzzOrNumberInRange1To100(0), Throws.ArgumentException);
            Assert.That(() => FizzBuzz.GetFizzOrBuzzOrNumberInRange1To100(115), Throws.ArgumentException);
        }
    }
}
