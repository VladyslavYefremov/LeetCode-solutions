using System.Collections.Generic;
using Leetcode.Tasks.Easy;

namespace Leetcode.Solutions.Easy
{
	public class ValidParentheses : IValidParentheses
	{
		public bool IsValid(string s)
		{
			var openingParentheses = new HashSet<char> { '(', '[', '{' };
			var closingParentheses = new HashSet<char> { ')', ']', '}' };

			var parenthesesDictionary = new Dictionary<char, char>
			{
				{'{', '}'},
				{'(', ')'},
				{'[', ']'},
			};

			var stack = new Stack<char>();

			foreach (var symbol in s)
			{
				if (stack.Count == 0)
				{
					stack.Push(symbol);
					continue;
				}

				if (closingParentheses.Contains(symbol))
				{
					char prevSymbol = stack.Pop(), closingSymbol;

					if (!parenthesesDictionary.TryGetValue(prevSymbol, out closingSymbol)) return false;

					if (closingSymbol == symbol) continue;

					return false;
				}

				if (openingParentheses.Contains(symbol)) return false;

				stack.Push(symbol);
			}

			return stack.Count == 0;
		}
	}
}