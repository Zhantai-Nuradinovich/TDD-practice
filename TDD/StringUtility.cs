using System;

namespace TDD
{
    public static class StringUtility
    {
        public static int Sum(string num1, string num2)
        {
            if (string.IsNullOrWhiteSpace(num1) || string.IsNullOrWhiteSpace(num2))
                throw new ArgumentNullException();

            int.TryParse(num1, out int num1Int);
            int.TryParse(num2, out int num2Int);
            return num1Int + num2Int;
        }
    }
}