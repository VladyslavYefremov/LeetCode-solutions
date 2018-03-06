using System;
using Leetcode.Tasks.Easy;

namespace Leetcode.Solutions.Easy
{
	public class ReverseIntegerSolution : IReverseInteger
	{
		// todo: use stack
		public int Reverse(int x)
		{
			if (x < 10 && x > -10)
			{
				return x;
			}

			var numberDigits = new byte[10]; // 10 is max amount of digits for type int (maxValue = 2147483647)
			var numberDigitsAmount = 0;
			var isNumberNegative = false;

			if (x < 0)
			{
				isNumberNegative = true;
				x = -x;
			}

			while (x > 0)
			{
				var digit = (byte)(x % 10); // get last digit

				numberDigits[numberDigitsAmount] = digit;

				x = x / 10;

				numberDigitsAmount++;
			}

			var result = 0;

			for (var i = numberDigitsAmount - 1; i >= 0; i--)
			{
				var j = numberDigitsAmount - i - 1;

				var conjunction = (long)Math.Pow(10, i) * numberDigits[j];

				if (conjunction > int.MaxValue) return 0; // overflow

				if (result + conjunction > int.MaxValue) return 0; // overflow

				result += (int)conjunction;
			}

			return isNumberNegative ? -result : result;
		}
	}
}