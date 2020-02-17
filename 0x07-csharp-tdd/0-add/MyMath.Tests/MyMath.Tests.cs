using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_Positive()
        {
            int a = 66;
            int b = 15;
            int c = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, c);
        }
        [Test]
        public void Add_Negative_Positive()
        {
            int a = -9;
            int b = 28;
            int c = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, c);
        }
        [Test]
        public void Add_Negative()
        {
            int a = -25;
            int b = -50;
            int c = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, c);
        }
    }
}