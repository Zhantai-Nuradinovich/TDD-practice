using System;
using System.Linq;

namespace TDD
{
    public static class PrimeComposite
    {
        static int[] _primeNumbers = new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        public static string GetPrimeOrCompositeWordInRange1To100(int number)
        {
            if (number < 1 || number > 100)
                throw new ArgumentException();

            if (_primeNumbers.Contains(number))
                return "Prime";

            if (!_primeNumbers.Contains(number) && number % 2 != 0)
                return "Composite";

            return number.ToString();
        }
    }
}