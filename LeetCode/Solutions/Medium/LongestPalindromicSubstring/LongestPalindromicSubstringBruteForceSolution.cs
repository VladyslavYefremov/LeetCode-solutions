using LeetCode.Tasks.Medium;

namespace LeetCode.Solutions.Medium.LongestPalindromicSubstring
{
	public class LongestPalindromicSubstringBruteForceSolution : ILongestPalindromicSubstring
	{
		public string LongestPalindrome(string s)
		{
			var len = s.Length;

			for (var subLen = len; subLen > 0; subLen--)
			{
				var combinationsAmount = len - subLen + 1;

				for (var i = 0; i < combinationsAmount; i++)
					if (IsPaPalindrome(s, i, subLen + i - 1))
						return s.Substring(i, subLen);
			}

			return string.Empty;
		}

		private bool IsPaPalindrome(string str, int startIndex, int endIndex)
		{
			var l = endIndex - startIndex + 1;
			var m = startIndex + l / 2;
			var iDelta = l % 2 == 0 ? -1 : 0;

			for (var i = startIndex; i < m; i++)
			{
				var leftSymbol = str[i];
				var rightSymbol = str[m + (m - i) + iDelta];

				if (leftSymbol != rightSymbol) return false;
			}

			return true;
		}
	}
}