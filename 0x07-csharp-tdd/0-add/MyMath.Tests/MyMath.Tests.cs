using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Adding_Positives()
        {
            int x = 66;
            int y = 15;
            int z = Operations.Add(x, y);
            Assert.AreEqual(x + y, z);
        }
        [Test]
        public void Adding_Negatives()
        {
            int x = -25;
            int y = -50;
            int z = Operations.Add(x, y);
            Assert.AreEqual(x + y, z);
        }
    }
}