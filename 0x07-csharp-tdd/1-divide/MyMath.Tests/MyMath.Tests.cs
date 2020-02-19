using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
      [Test]
		public void Divide_M()
		{
			int[,] matrix = new int[2, 2] { { 8, 4 }, { 4, 10 } };
			int num = 2;

			int[,] output = MyMath.Matrix.Divide(matrix, num);

			Assert.AreEqual(new int[2, 2] { { 4, 2 }, { 2, 5 } }, output);
		}
	
		[Test]
		public void Divide_Zero()
		{
			int[,] matrix = new int[2, 2] { { 8, 2 }, { 2, 6 } };
			int num = 0;

			int[,] output = MyMath.Matrix.Divide(matrix, num);

			Assert.AreEqual(null, output);
		}

        [Test]
		public void Divide_NULL()
		{
			int[,] matrix = new int[2, 2] { { 8, 4 }, { 2, 6 } };
			int nope = 0;

			int[,] output = MyMath.Matrix.Divide(matrix, nope);

			Assert.AreEqual(null, output);
		}


    }
}
