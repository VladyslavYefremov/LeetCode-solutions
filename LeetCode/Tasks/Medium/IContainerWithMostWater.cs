﻿namespace LeetCode.Tasks.Medium
{
	/// <summary>
	/// Given n non-negative integers a1, a2, ..., an, where each represents
	/// a point at coordinate (i, ai). n vertical lines are drawn such
	/// that the two endpoints of line i is at (i, ai) and (i, 0).
	///
	/// Find two lines, which together with x-axis forms a container,
	/// such that the container contains the most water.
	/// </summary>
	public interface IContainerWithMostWater
	{
		int MaxArea(int[] height);
	}
}