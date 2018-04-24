using System;
using LeetCode.Tasks.Medium;

namespace LeetCode.Solutions.Medium
{
	public class ContainerWithMostWater : IContainerWithMostWater
	{
		public int MaxArea(int[] height)
		{
			var n = height.Length;
			var maxArea = 0;
			var leftIndex = 0;
			var rightIndex = n - 1;

			while (leftIndex != rightIndex)
			{
				var leftValue = height[leftIndex];
				var rightValue = height[rightIndex];
				var minValue = Math.Min(leftValue, rightValue);
				var distance = Math.Abs(rightIndex - leftIndex);

				var area = minValue * distance;

				if (area > maxArea) maxArea = area;

				if (minValue == leftValue) leftIndex++;
				else if (minValue == rightValue) rightIndex--;
			}

			return maxArea;
		}
	}
}