using NUnit.Framework;

namespace Text.Tests
{
	[TestFixture]
	public class StrTests
	{
		[Test]
		public void OK_Palindrome()
		{
			string s = "Racecar";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}

		[Test]
		public void Check_Palindrome()
		{
			string s = "A man, a plan, a canal: Panama.";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}

		[Test]
		public void Empty_String()
		{
			string s = "";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}
	}
}