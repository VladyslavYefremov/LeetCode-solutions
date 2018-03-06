using System;
using Leetcode.Tasks.Easy;

namespace Leetcode.Solutions.Easy
{
	public class TwoSumBruteSolution : ITwoSum
	{
		public int[] TwoSum(int[] nums, int target)
		{
			var l = nums.Length;

			for (var i = 0; i < l - 1; i++)
				for (var j = i + 1; j < l; j++)
					if (nums[i] + nums[j] == target)
						return new[] { i, j };

			throw new ArgumentException();
		}
	}
}