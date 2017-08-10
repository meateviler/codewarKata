namespace DuplicateCount
{
	public class Kata
	{
		public static int DuplicateCount(string str)
		{
			if (string.IsNullOrEmpty(str))
				return 0;

			var tmp = str.ToLower();
			var currentLen = tmp.Length;
			var duplicateCount = 0;
			while (tmp.Length > 0)
			{
				tmp = tmp.Replace(tmp[0].ToString(), string.Empty);
				if (tmp.Length + 1 < currentLen)
				{
					duplicateCount++;
				}
				currentLen = tmp.Length;
			}

			return duplicateCount;
		}
	}
}