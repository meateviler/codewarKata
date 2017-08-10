using System;

namespace PalindromeChainLength
{
	public static class Kata
	{
		public static int palindromeChainLength(int n)
		{
			var step = 0;
			long tmp = n;
			while (!IsPalindrome(tmp))
			{
				tmp = tmp + ReverseNumber(tmp);
				step++;
			}

			return step;
		}

		private static bool IsPalindrome(long n)
		{
			return n == ReverseNumber(n);
		}

		private static long ReverseNumber(long n)
		{
			var arrayN = n.ToString().ToCharArray();
			Array.Reverse(arrayN);
			return Convert.ToInt64(new string(arrayN));
		}
	}
}