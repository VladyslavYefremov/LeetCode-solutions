using LeetCode.DataStructures;
using LeetCode.Tasks.Medium;

namespace LeetCode.Solutions.Medium
{
	public class AddTwoNumbersSolution : IAddTwoNumbers
	{
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			var current1 = l1;
			var current2 = l2;

			ListNode resultHead = null;
			ListNode currentResultNode = null;

			while (current1 != null || current2 != null)
			{
				if (resultHead == null)
				{
					resultHead = new ListNode(0);
				}

				if (currentResultNode == null)
				{
					currentResultNode = resultHead;
				}
				else
				{
					if (currentResultNode.next == null) currentResultNode.next = new ListNode(0);

					currentResultNode = currentResultNode.next;
				}

				if (current1 != null) currentResultNode.val += current1.val;
				if (current2 != null) currentResultNode.val += current2.val;

				current1 = current1?.next;
				current2 = current2?.next;

				if (!(currentResultNode.val < 10))
				{
					currentResultNode.next = new ListNode(currentResultNode.val / 10);
					currentResultNode.val %= 10;
				}
			}

			return resultHead;
		}
	}
}