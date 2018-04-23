using LeetCode.DataStructures;

namespace LeetCode.Tasks.Easy
{
	/// <summary>
	/// Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
	/// 
	/// Example:
	///		Input: 1->2->4, 1->3->4
	///		Output: 1->1->2->3->4->4
	/// </summary>
	public interface IMergeTwoSortedLists
	{
		ListNode MergeTwoLists(ListNode l1, ListNode l2);
	}
}
