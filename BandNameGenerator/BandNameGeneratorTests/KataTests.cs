using NUnit.Framework;

namespace BandNameGenerator.Tests
{
	[TestFixture()]
	public class KataTests
	{
		[TestCase("k", ExpectedResult = "The K", TestName = "k_Should_be_The K")]
		[TestCase("aa", ExpectedResult = "Aaa", TestName = "aa_Should_be_The Aaa")]
		[TestCase("knife", ExpectedResult = "The Knife", TestName = "knife_Should_be_The Knife")]
		[TestCase("tart", ExpectedResult = "Tartart", TestName = "tart_Should_be_Tartart")]
		[TestCase("sandles", ExpectedResult = "Sandlesandles", TestName = "sandles_Should_be_The Sandlesandles")]
		[TestCase("bed", ExpectedResult = "The Bed", TestName = "bed_Should_be_The Bed")]
		public string BandNameGeneratorTest(string input)
		{
			return Kata.BandNameGenerator(input);
		}
	}
}