using Leetcode.Tasks.Easy;

namespace Leetcode.Solutions.Easy
{
	public class LongestCommonPrefixSolution : ILongestCommonPrefix
	{
		public string LongestCommonPrefix(string[] strs)
		{
			if (strs.Length == 0) return string.Empty;

			var firstString = strs[0];
			var firstStringLength = firstString.Length;

			for (var charsIndex = 0; charsIndex < firstStringLength; charsIndex++)
			{
				var prefix = firstString.Substring(0, firstStringLength - charsIndex);
				var match = true;

				for (var stringsIndex = 0; stringsIndex < strs.Length; stringsIndex++)
				{
					if (!strs[stringsIndex].StartsWith(prefix))
					{
						match = false;
						break;
					}
				}

				if (match) return prefix;
			}

			return string.Empty;
		}
	}
}