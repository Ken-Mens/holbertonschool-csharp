using NUnit.Framework;

namespace Text.Tests
{
	///<summary>Unit testing for unique string</summary>
	[TestFixture]
	public class StrTexts
	{
		///<summary>checking for normal operation</summary>
		[Test]
		public void Unique_check()
		{
			string st = "ssissss";

			int output = Str.UniqueChar(st);

			Assert.AreEqual(2, output);
		}


		///<summary>check if string is empty</summary>
		[Test]
		public void Empty_check()
		{
			string st = "";

			int output = Str.UniqueChar(st);

			Assert.AreEqual(-1, output);
		}

	}
}