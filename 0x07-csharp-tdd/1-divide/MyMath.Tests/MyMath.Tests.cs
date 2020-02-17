using System;
using System.IO;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            StreamWriter standardOut =
                new StreamWriter(Console.OpenStandardOutput());
            standardOut.AutoFlush = true;
            Console.SetOut(standardOut);
        }
        [Test]
        public void Divide_Zero()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                int[,] newMat = {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                };
                int num = 0;
                string output =
                    string.Format("Num cannot be 0{0}", Environment.NewLine);
                int[,] result = MyMath.Matrix.Divide(newMat, num);
                Assert.That(output, Is.EqualTo(sw.ToString()));
                Assert.That(result, Is.Null);

            }
        }
     
        [Test]
        public void Divide_Empty()
        {
            int[,] newMat = {};
            int num = 2;
            int [,] output = {};
            int[,] result = MyMath.Matrix.Divide(newMat, num);
            Assert.That(result, Is.EqualTo(output));
        }
    }
}
