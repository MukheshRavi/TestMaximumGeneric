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
        /// <summary>
        /// Testing to return maximum number among three numbers
        /// Giving maximum at First Position
        /// </summary>
        [TestMethod]
        public void TestMaxFloatone()
        {
            ///Arrange
            float expected = 98.7f;
            ///Act
            ///Calling GetMaximum method 
            float actual = NonGeneric.GetMaxfloatNumberAmongThree(98.7f,27.5f, 34.9f);
            ///Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing to return maximum number among three numbers
        /// Giving maximum at Second Position
        /// </summary>
        [TestMethod]
        public void TestMaxFloatTwo()
        {
            ///Arrange
            float expected = 98.7f;
            ///Act
            ///Calling GetMaximum method 
            float actual = NonGeneric.GetMaxfloatNumberAmongThree(27.5f,98.7f,34.9f);
            ///Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing to return maximum number among three numbers
        /// Giving maximum at third Position
        /// </summary>
        [TestMethod]
        public void TestMaxFloatThree()
        {
            ///Arrange
            float expected = 98.7f;
            ///Act
            ///Calling GetMaximum method 
            float actual = NonGeneric.GetMaxfloatNumberAmongThree(27.5f, 34.9f, 98.7f);
            ///Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing to return maximum number among three String numbers
        /// Giving maximum at First Position
        /// </summary>
        [TestMethod]
        public void TestMaxStringone()
        {
            ///Arrange
            string expected = "def";
            ///Act
            ///Calling GetMaximum method 
            string actual = NonGeneric.GetMaxStringNumberAmongThree("def", "cdf", "asd");
            ///Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing to return maximum number among three String numbers
        /// Giving maximum at Second Position
        /// </summary>
        [TestMethod]
        public void TestMaxStringTwo()
        {
            ///Arrange
            string expected = "def";
            ///Act
            ///Calling GetMaximum method 
            string actual = NonGeneric.GetMaxStringNumberAmongThree("cdf","def","asd");
            ///Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing to return maximum number among three String numbers
        /// Giving maximum at Second Position
        /// </summary>
        [TestMethod]
        public void TestMaxStringThree()
        {
            ///Arrange
            string expected = "def";
            ///Act
            ///Calling GetMaximum method 
            string actual = NonGeneric.GetMaxStringNumberAmongThree("cdf", "asd","def");
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

