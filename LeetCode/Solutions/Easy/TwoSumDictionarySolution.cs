using System;
using System.Collections.Generic;
using Leetcode.Tasks.Easy;

namespace Leetcode.Solutions.Easy
{
	public class TwoSumDictionarySolution : ITwoSum
	{
		public int[] TwoSum(int[] nums, int target)
		{
			var dictionary = new Dictionary<int, int>();

			for (var i = 0; i < nums.Length; i++)
			{
				var number = nums[i];
				var numberNeeded = target - number;
				int indexOfNeededNumber;

				if (dictionary.TryGetValue(numberNeeded, out indexOfNeededNumber))
				{
					return new[] { indexOfNeededNumber, i };
				}

				dictionary[number] = i;
			}

			throw new ArgumentException();
		}
	}
}