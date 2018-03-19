namespace LeetCode.Tasks.Medium
{
	/// <summary>
	/// Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
	/// 
	/// Example:
	///		Input: "babad"
	///		Output: "bab"
	///		Note: "aba" is also a valid answer.
	/// 
	/// Example: 
	///		Input: "cbbd"
	///		Output: "bb"
	/// 
	///	ref: https://leetcode.com/problems/longest-palindromic-substring/
	/// </summary>
	public interface ILongestPalindromicSubstring
	{
		string LongestPalindrome(string s);
	}
}