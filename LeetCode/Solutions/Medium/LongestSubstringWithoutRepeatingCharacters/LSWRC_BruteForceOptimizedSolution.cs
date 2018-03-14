using System;
using System.Collections.Generic;
using LeetCode.Tasks.Medium;

namespace LeetCode.Solutions.Medium.LongestSubstringWithoutRepeatingCharacters
{
	/// <summary>
	/// Brute Force optimized implementation [Accepted]
	/// 
	/// Runtime: ~176 ms
	/// </summary>
	public class LSWRC_BruteForceOptimizedSolution : ILongestSubstringWithoutRepeatingCharacters
	{
		public int LengthOfLongestSubstring(string s)
		{
			var l = s.Length;

			if (l <= 1) return l;

			var symbolsSet = new HashSet<char>();
			var maxLen = 0;

			for (int i = 0, j = 1; j <= l; j++)
			{
				symbolsSet.Clear();

				var hasDuplicates = false;

				for (var k = i; k < j; k++)
				{
					var symbol = s[k];

					if (!symbolsSet.Add(symbol))
					{
						hasDuplicates = true;
						break;
					}
				}

				if (!hasDuplicates)
				{
					maxLen = Math.Max(maxLen, j - i);
					continue;
				}

				i++;
			}

			return maxLen;
		}
	}
}