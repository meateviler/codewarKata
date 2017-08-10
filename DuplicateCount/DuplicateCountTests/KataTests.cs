using NUnit.Framework;

namespace DuplicateCount.Tests
{
	[TestFixture()]
	public class KataTests
	{
		[TestCase("", ExpectedResult = 0, TestName = "Empty should be 0")]
		[TestCase("abcde", ExpectedResult = 0, TestName = "abcde should be 0")]
		[TestCase("aabbcde", ExpectedResult = 2, TestName = "aabbcde should be 2")]
		[TestCase("aabBcde", ExpectedResult = 2, TestName = "aabBcde should be 2 ignore case")]
		[TestCase("Indivisibility", ExpectedResult = 1, TestName = "Indivisibility should be 2")]
		[TestCase("Indivisibilities", ExpectedResult = 2, TestName = "Indivisibilities should be 2, characters may not be adjacent")]
		public int DuplicateCountTest(string input)
		{
			return Kata.DuplicateCount(input);
		}
	}
}