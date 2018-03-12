using LeetCode.Tasks.Hard;

namespace LeetCode.Solutions.Hard
{
	/// <summary>
	/// Find median of two sorted arrays by using extra space
	/// </summary>
	public class MedianOfTwoSortedArraysSolution : IMedianOfTwoSortedArrays
	{
		public double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			var l1 = nums1.Length;
			var l2 = nums2.Length;
			var n = l1 + l2;

			var aggregator = new int[n];

			int ai1 = 0, // element index of the first array
				ai2 = 0, // element index of the second array
				aia = 0; // element index of the aggregator array

			while (ai1 < l1 || ai2 < l2)
			{
				if (ai1 < l1)
				{
					if (ai2 < l2)
					{
						if (nums1[ai1] < nums2[ai2])
						{
							aggregator[aia++] = nums1[ai1];
							ai1++;
						}
						else
						{
							aggregator[aia++] = nums2[ai2];
							ai2++;
						}
					}
					else
					{
						aggregator[aia++] = nums1[ai1];
						ai1++;
					}
				}
				else if (ai2 < l2)
				{
					aggregator[aia++] = nums2[ai2];
					ai2++;
				}
			}

			var medianIndex = (n - 1) / 2;

			return n % 2 != 0 ? aggregator[medianIndex] : (aggregator[medianIndex] + aggregator[medianIndex + 1]) / 2.0;
		}
	}
}