using System.Collections.Generic;
using LeetCode.Tasks.Medium;

namespace LeetCode.Solutions.Medium.LongestSubstringWithoutRepeatingCharacters
{
	/// <summary>
	/// Optimized algorithm
	/// 
	/// Runtime: ~108 ms
	/// </summary>
	public class LSWRC_OptimizedSolution : ILongestSubstringWithoutRepeatingCharacters
	{
		public int LengthOfLongestSubstring(string s)
		{
			var l = s.Length;

			var symbolsSet = new HashSet<char>();
			var maxLen = 0;

			for (int i = 0, j = 0; j < l;)
			{
				var iSymbol = s[i];
				var jSymbol = s[j];

				if (symbolsSet.Add(jSymbol))
				{
					if ((j - i + 1) > maxLen) maxLen = (j - i + 1);

					symbolsSet.Add(jSymbol);
					j++;
				}
				else
				{
					symbolsSet.Remove(iSymbol);
					i++;
				}
			}

			return maxLen;
		}
	}
}