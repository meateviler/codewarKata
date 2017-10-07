using NUnit.Framework;

namespace NextBiggerNumberWithTheSameDigits.Tests
{
	[TestFixture()]
	public class KataTests
	{
		[TestCase(12, ExpectedResult = 21, TestName = "12 shouldBe 21")]
		[TestCase(513, ExpectedResult = 531, TestName = "513 shouldBe 531")]
		[TestCase(2017, ExpectedResult = 2071, TestName = "2017 shouldBe 2071")]
		[TestCase(414, ExpectedResult = 441, TestName = "414 shouldBe 441")]
		[TestCase(144, ExpectedResult = 414, TestName = "144 shouldBe 414")]
		[TestCase(131316994, ExpectedResult = 131319469, TestName = "131316994 shouldBe 131319469")]
		public long NextBiggerNumberTest(long input)
		{
			return Kata.NextBiggerNumber(input);
		}
	}
}