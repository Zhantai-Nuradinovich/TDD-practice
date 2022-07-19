using NUnit.Framework;
using System.Linq;
using TDD;

namespace Task1.Tests
{
    [TestFixture]
    public class TDDTests
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
        public int Sum_TwoCorrectNumbers_ReturnsSum(string num1, string num2)
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
