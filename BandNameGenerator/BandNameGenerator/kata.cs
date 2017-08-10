namespace BandNameGenerator
{
	public class Kata
	{
		public static string BandNameGenerator(string str)
		{
			var tmp = str.ToLower();
			if (tmp.Length == 1)
				return ConvertFirstCharToUpperAndAddThe(tmp);
			if (IsStartAndEndSameLetter(tmp))
			{
				return ConvertFirstCharToUpperWithWholeWordAndRepeatOnceWithoutFirstChar(tmp);
			}

			return ConvertFirstCharToUpperWithWholeWordAndAddThe(tmp);
		}

		private static string ConvertFirstCharToUpperWithWholeWordAndRepeatOnceWithoutFirstChar(string str)
		{
			return ConvertFirstCharToUpper(str) + str.Substring(1, str.Length-2) + str;
		}

		private static string ConvertFirstCharToUpperWithWholeWordAndAddThe(string str)
		{
			return ConvertFirstCharToUpperAndAddThe(str) + str.Substring(1, str.Length - 1);
		}

		private static bool IsStartAndEndSameLetter(string str)
		{
			return str[0] == str[str.Length - 1];
		}

		private static string ConvertFirstCharToUpper(string str)
		{
			return str[0].ToString().ToUpper();
		}

		private static string ConvertFirstCharToUpperAndAddThe(string str)
		{
			return "The " + ConvertFirstCharToUpper(str);
		}
	}
}