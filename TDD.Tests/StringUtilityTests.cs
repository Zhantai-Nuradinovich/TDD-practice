using NUnit.Framework;
using System.Linq;
using TDD;

namespace TDD.Tests
{
    /*
        Write a simple String Sum utility with a function string Sum(string num1, string num2), which can accept only natural numbers and will return their sum. Replace entered number with 0 (zero) if entered number is not a natural number.
        Stat with a simplest test case with an empty string
        Create a simple method string Sum(string num1, string num2)
        Write a test to pass small numbers and refactor, if test passed
        try to write more code and refactor
     */
    [TestFixture]
    public class StringUtilityTests
    {
        [Test]
        public void Sum_EmptyStrings_ThrowsArgumentException()
        {
            Assert.That(() => StringUtility.Sum("", ""), Throws.ArgumentNullException);
        }

        [TestCase("1", "1", ExpectedResult = 2)]
        [TestCase("3", "0", ExpectedResult = 3)]
        [TestCase("3.5", "0", ExpectedResult = 0)]
        [TestCase("-3", "0", ExpectedResult = -3)]
        [TestCase("-3999", "-", ExpectedResult = -3999)]
        [TestCase("-##$#", "dss654", ExpectedResult = 0)]
        public int Sum_TwoNumbers_ReturnsSum(string num1, string num2)
        {
            return StringUtility.Sum(num1, num2);
        }

        [Test]
        public void Sum_NullSource_ThrowsArgumentNullException()
        {
            Assert.That(() => StringUtility.Sum(null, "42"), Throws.ArgumentNullException);
        }
    }
}
