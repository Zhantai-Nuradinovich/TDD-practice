using NUnit.Framework;
using System.Linq;
using TDD;

namespace TDD.Tests
{
    /*
            - Write a program that prints numbers within specified range lets say 1 to 100. 
            - If number is ```prime``` print 'prime' instead of the number. 
            - If number is ```composite``` but not ```even``` print 'composite' instead of number.
            - Else print number. 
            - Reference(s)
            - [Prime numbers](https://en.wikipedia.org/wiki/Prime_number), 
            - [Composite numbers](https://en.wikipedia.org/wiki/Composite_number), 
            - [odd even](https://en.wikipedia.org/wiki/Parity_(mathematics))
     */
    [TestFixture]
    public class PrimeCompositeTests
    {
        [TestCase(7, ExpectedResult = "Prime")]
        [TestCase(47, ExpectedResult = "Prime")]
        [TestCase(9, ExpectedResult = "Composite")]
        [TestCase(49, ExpectedResult = "Composite")]
        [TestCase(48, ExpectedResult = "48")]
        [TestCase(1, ExpectedResult = "1")]
        public string GetFizzBuzz_CorrectNumbers_ReturnsFizzBuzzOrNumber(int number)
        {
            return PrimeComposite.GetPrimeOrCompositeWordInRange1To100(number);
        }
        [Test]
        public void GetFizzBuzz_OutOfRangeNumbers_ThrowsArgumentException()
        {
            Assert.That(() => PrimeComposite.GetPrimeOrCompositeWordInRange1To100(-5), Throws.ArgumentException);
            Assert.That(() => PrimeComposite.GetPrimeOrCompositeWordInRange1To100(0), Throws.ArgumentException);
            Assert.That(() => PrimeComposite.GetPrimeOrCompositeWordInRange1To100(115), Throws.ArgumentException);
        }
    }
}
