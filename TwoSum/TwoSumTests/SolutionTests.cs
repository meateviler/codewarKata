using NUnit.Framework;

namespace TwoSum.Tests
{
	[TestFixture()]
	public class SolutionTests
	{
		[TestCase(new int[] { 2, 7, 11, 15 }, 0, ExpectedResult = new int[] { 0, 1 }, TestName = "Empty should be 0")]
		public int[] TwoSumTest(int[] nums, int target)
		{
			Solution t = new Solution();
			return t.TwoSum(nums, target);
		}
	}
}