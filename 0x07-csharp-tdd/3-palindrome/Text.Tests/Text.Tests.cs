using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsPalindrome_Punctuation()
        {
            string test = "!?. :;";
            Assert.That(Text.Str.IsPalindrome(test), Is.True);
        }
        [Test]
        public void IsPalindrome_A()
        {
            string test = "A man, a plan, a canal: Panama.";
            Assert.That(Text.Str.IsPalindrome(test), Is.True);
        }
        [Test]
        public void IsPalindrome_B()
        {
            string test = "Welcome! This is Holberton.";
            Assert.That(Text.Str.IsPalindrome(test), Is.False);
        }
         [Test]
        public void IsPalindrome_C()
        {
            string test = "Welcome! This is Holberton.";
            Assert.That(Text.Str.IsPalindrome(test), Is.False);
        }
    }
}