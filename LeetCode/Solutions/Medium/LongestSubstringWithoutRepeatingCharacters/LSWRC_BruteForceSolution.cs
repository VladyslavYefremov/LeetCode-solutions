using System.Collections.Generic;
using LeetCode.Tasks.Medium;

namespace LeetCode.Solutions.Medium.LongestSubstringWithoutRepeatingCharacters
{
	/// <summary>
	/// Brute Force [Not accepted: 982 / 983 test cases passed]
	/// </summary>
	public class LSWRC_BruteForceSolution : ILongestSubstringWithoutRepeatingCharacters
	{
		public int LengthOfLongestSubstring(string s)
		{
			var l = s.Length;

			var symbolsSet = new HashSet<char>();

			for (var i = 0; i < l; i++)
			{
				var substringsAmount = i + 1;

				var substringLength = l - i;

				for (var j = 0; j < substringsAmount; j++)
				{
					symbolsSet.Clear();

					var substring = s.Substring(j, substringLength);
					var hasUniqueOnlySymbols = true;

					foreach (var symbol in substring)
					{
						if (symbolsSet.Add(symbol)) continue;

						hasUniqueOnlySymbols = false;
						break;
					}

					if (hasUniqueOnlySymbols) return substring.Length;
				}
			}

			return 0;
		}
	}
}