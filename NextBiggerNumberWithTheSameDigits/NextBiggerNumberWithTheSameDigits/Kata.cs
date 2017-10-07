using System.Linq;

namespace NextBiggerNumberWithTheSameDigits
{
	public class Kata
	{
		public static long NextBiggerNumber(long n)
		{
			var strN = n.ToString().ToArray();
			var pivot = -1;
			for (int i = strN.Length - 1; i >0; i--)
			{
				if (strN[i] > strN[i - 1])
				{
					pivot = i-1;
					break;
				}
			}
			if (pivot == -1)
				return -1;
			var leftHandNoChangeNumber = strN.Take(pivot);
			var lowestNumButGreatThanPivot = strN.Skip(pivot).Where(x => x>strN[pivot]).Min();
			var rightHandSohouldBeReOrder = strN.Skip(pivot).ToList();
			rightHandSohouldBeReOrder.Remove(lowestNumButGreatThanPivot);
			var afterReOrder = string.Join("", rightHandSohouldBeReOrder.OrderBy(x => x).ToArray());
			var strValue = string.Join("", leftHandNoChangeNumber.ToArray());
			strValue = string.Concat(string.Concat(strValue, lowestNumButGreatThanPivot), afterReOrder);
			return long.Parse(strValue);
		}
	}
}