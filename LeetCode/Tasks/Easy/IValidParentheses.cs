namespace Leetcode.Tasks.Easy
{
	/// <summary>
	/// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
	/// 
	/// The brackets must close in the correct order, "()", "(([]){})" and "()[]{}" are all valid but "(]" and "([)]" are not.
	/// </summary>
	public interface IValidParentheses
	{
		bool IsValid(string s);
	}
}