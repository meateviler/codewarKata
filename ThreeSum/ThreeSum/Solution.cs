using System;
using System.Collections.Generic;

namespace ThreeSum
{
	public class Solution
	{
		public IList<IList<int>> ThreeSum(int[] nums)
		{
			Array.Sort(nums);
			IList<IList<int>> list = new List<IList<int>>();
			for (int i = 0; i< nums.Length; i++)
			{
				var target = 0 - nums[i];
				if (nums[i] > 0)
				{
					break;
				}
				var front = i + 1;
				var rear = nums.Length - 1;

				while (front < rear)
				{
					var sum = nums[front] + nums[rear];
					if (sum < target)
					{
						front++;
					}
					else if (sum > target)
					{
						rear--;
					}
					else
					{
						var num1 = nums[i];
						var num2 = nums[front];
						var num3 = nums[rear];
						int[] item = new int[] { num1, num2, num3 };
						list.Add(item);

						while (front < rear && nums[front] == num2)
						{
							front++;
						}
						while (front < rear && nums[rear] == num3)
						{
							rear--;
						}
					}
				}

				while (i + 1 < nums.Length && nums[i + 1] == nums[i])
				{
					i++;
				}
			}

			return list;
		}
	}
}