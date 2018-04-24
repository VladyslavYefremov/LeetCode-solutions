using LeetCode.DataStructures;
using LeetCode.Tasks.Easy;

namespace Leetcode.Solutions.Easy
{
	public class MergeTwoSortedLists : IMergeTwoSortedLists
	{
		public ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			ListNode headNode = null;
			ListNode currentNode = null;

			while (l1 != null || l2 != null)
			{
				var smallest = l1 == null ? l2 : (l2 == null ? l1 : (l1.val < l2.val ? l1 : l2));
				var smallestNode = new ListNode(smallest.val);

				if (l1 == smallest) l1 = l1.next;
				else if (l2 == smallest) l2 = l2.next;

				if (headNode == null)
				{
					headNode = smallestNode;
					currentNode = headNode;

					continue;
				}

				currentNode.next = smallestNode;
				currentNode = currentNode.next;
			}

			return headNode;
		}
	}
}