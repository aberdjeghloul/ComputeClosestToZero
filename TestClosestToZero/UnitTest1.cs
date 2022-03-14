using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputeClosestToZero;

namespace TestClosestToZero
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_No_Temperature()
        {
            Assert.AreEqual(ClosetToZero.ComputeClosestToZero(new int[] { }), 0);
        }

        [TestMethod]
        public void Test_Simple()
        {
            Assert.AreEqual(ClosetToZero.ComputeClosestToZero(new int[] { 7, 5, 9, 1, 4 }), 1);
        }

        [TestMethod]
        public void Test_Positive_one_value()
        {
            Assert.AreEqual(ClosetToZero.ComputeClosestToZero(new int[] { 5526 }), 5526);
        }

        [TestMethod]
        public void Test_Negative_one_value()
        {
            Assert.AreEqual(ClosetToZero.ComputeClosestToZero(new int[] { -273 }), -273);
        }

        [TestMethod]
        public void Test_only_negatives()
        {
            Assert.AreEqual(ClosetToZero.ComputeClosestToZero(new int[] { -15, -7, -9, -14, -12 }), -7);
        }

        [TestMethod]
        public void Test_2_negatives()
        {
            Assert.AreEqual(ClosetToZero.ComputeClosestToZero(new int[] { -10, -10 }), -10);
        }

        [TestMethod]
        public void Test_When_Several_Temperatures_Are_Closest_To_0_Then_Positive_IsChosen()
        {
            Assert.AreEqual(ClosetToZero.ComputeClosestToZero(new int[] { -15, 3, 9, 14, -3, 12, -3 }), 3);
        }
    }
}
