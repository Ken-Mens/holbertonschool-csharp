using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Adding_Positives()
        {
            int x = 36;
            int y = 24;
            int z = Operations.Add(x, y);
            Assert.AreEqual(x + y, z);
        }
    }
}