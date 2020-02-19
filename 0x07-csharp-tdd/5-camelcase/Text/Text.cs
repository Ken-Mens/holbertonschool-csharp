using System;

namespace Text
{
	///<summary>String operations</summary>
	public class Str
	{
		///<summary>Method that returns  the number of words in said string</summary>
		public static int CamelCase(string s)
		{
			if (s.Length == 0 || s == null)
			{
				return 0;
			}
			int count = 1;
			foreach (char idx in s)
			{
				if (Char.IsUpper(idx))
				{
					count++;
				}
			}
			return count;
		}
	}
}