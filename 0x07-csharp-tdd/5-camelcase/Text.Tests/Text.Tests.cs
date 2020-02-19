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
        public void CamelC_Empty()
        {
            string test = "";
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void CamelC_One()
        {
            string test = "wee";
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void CamelC_Null()
        {
            string test = null;
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}