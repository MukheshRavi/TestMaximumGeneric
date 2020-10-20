using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;

namespace TestingMaximum
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Testing to return maximum number among three numbers
        /// Giving maximum at First Position
        /// </summary>
        [TestMethod]
        public void TestMaxIntOne()
        {
            ///Arrange
            int expected = 45;
            ///Act
            ///Calling GetMaximum method 
            int actual = NonGeneric.GetMaxIntNumberAmongThree(45,23,13);
            ///Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing to return maximum number among three numbers
        /// Giving maximum at Second Position
        /// </summary>
        [TestMethod]
        public void TestMaxIntTwo()
        {
            ///Arrange
            int expected = 45;
            ///Act
            ///Calling GetMaximum method 
            int actual = NonGeneric.GetMaxIntNumberAmongThree(23,45, 13);
            ///Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing to return maximum number among three numbers
        /// Giving maximum at Third Position
        /// </summary>
        [TestMethod]
        public void TestMaxIntThree()
        {
            ///Arrange
            int expected = 45;
            ///Act
            ///Calling GetMaximum method 
            int actual = NonGeneric.GetMaxIntNumberAmongThree(23, 13,45);
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
