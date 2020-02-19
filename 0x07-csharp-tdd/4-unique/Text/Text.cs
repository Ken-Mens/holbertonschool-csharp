using System;

namespace Text
{
	///<summary> string operations</summary>
	public class Str
	{
		///<summary> method to get first unique index</summary>
		public static int UniqueChar(string s)
		{
			if (s == "")
			{
				return (-1);
			}

			char bc = s[0];
            var sizing =  s.Length;
            int index = 0;
			for (; index < sizing; index++)
			{
				if (s[index] != bc)
				{
					return index;
				}
				bc = s[index];
			}
			return (-1);
		}
	}
}