using Leetcode.Tasks.Easy;

namespace Leetcode.Solutions.Easy
{
	public class PalindromeNumberSolution : IPalindromeNumber
	{
		public bool IsPalindrome(int x)
		{
			if (x < 0) return false;

			if (x < 10) return true;

			var numberDigits = new byte[10]; // 10 is max amount of digits for type int (maxValue = 2147483647)
			var numberDigitsAmount = 0;

			if (x < 0)
			{
				x = -x;
			}

			while (x > 0)
			{
				var digit = (byte)(x % 10); // get last digit

				numberDigits[numberDigitsAmount] = digit;

				x = x / 10;

				numberDigitsAmount++;
			}

			var numberCenterIndex = numberDigitsAmount / 2;

			for (var i = 0; i < numberCenterIndex; i++)
			{
				var leftDigit = numberDigits[i];
				var rightDigit = numberDigits[numberDigitsAmount - i - 1];

				if (leftDigit != rightDigit) return false;
			}

			return true;
		}
	}
}