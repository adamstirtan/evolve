using Evolve.Math;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Evolve.Tests
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void Addition()
        {
            var v1 = new Vector(1, 2, 3);
            var v2 = new Vector(0, 0, 1);

            var v3 = v1.Add(v2);

            Assert.AreEqual(1, v3[0]);
            Assert.AreEqual(2, v3[1]);
            Assert.AreEqual(4, v3[2]);
        }
    }
}
