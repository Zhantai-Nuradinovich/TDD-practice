using System;

namespace TDD
{
    public static class FizzBuzz
    {
        public static string GetFizzOrBuzzOrNumberInRange1To100(int number)
        {
            if (number < 1 || number > 100)
                throw new ArgumentException();

            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}