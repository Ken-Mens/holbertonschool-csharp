using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
	[TestFixture]
	public class OperationsTests
	{
		[Test]
		public void Max_test()
		{
			List<int> array = new List<int>();
			array.Add(3);
			array.Add(-4);
			array.Add(9);
			array.Add(5);
			array.Add(1);

			int output = Operations.Max(array);

			Assert.AreEqual(9, output);
		}

		[Test]
		public void Max_Empty_List()
		{
			List<int> array = new List<int>();

			int output = Operations.Max(array);

			Assert.AreEqual(0, output);
		}
	}
}