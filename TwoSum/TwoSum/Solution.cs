using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
	public class Solution
	{
		public int[] TwoSum(int[] nums, int target)
		{
			for (int i = 0; i< nums.Length; i++)
			{
				for (int j = 0; j<i; j++)
				{
					if (nums[i] + nums[j]  == target)
					{
						return new int[] { i, j };
					}
				}
			}
			return new int[] { 0, 1 };
		}
	}
}