using NUnit.Framework;

namespace PalindromeChainLength.Tests
{
	[TestFixture()]
	public class KataTests
	{
		[TestCase(5, ExpectedResult = 0, TestName = "5 should be 0 steps")]
		[TestCase(44, ExpectedResult = 0, TestName = "44 should be 0 steps")]
		[TestCase(171, ExpectedResult = 0, TestName = "171 should be 0 steps")]
		[TestCase(87, ExpectedResult = 4, TestName = "87 should be 4 steps")]
		[TestCase(89, ExpectedResult = 24, TestName = "89 should be 24 steps")]
		public int palindromeChainLengthTest(int num)
		{
			return Kata.palindromeChainLength(num);
		}
	}
}