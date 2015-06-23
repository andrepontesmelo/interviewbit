using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spiral;

namespace SpiralTest
{
    /// <summary>
    /// Summary description for DelimiterTest
    /// </summary>
    [TestClass]
    public class DelimitersTest
    {
        Spiral.Demiliters delimiters;
        int[,] matrix;

        public DelimitersTest()
        {
            matrix = new int[4,7];
            delimiters = new Demiliters(matrix);
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestLeft()
        {
            Assert.IsTrue(delimiters.Left == 0);
        }

        [TestMethod]
        public void TestTop()
        {
            Assert.IsTrue(delimiters.Top == 0);
        }

        [TestMethod]
        public void TestBottom()
        {
            Assert.IsTrue(delimiters.Bottom == 3);
        }

        [TestMethod]
        public void TestRight()
        {
            Assert.IsTrue(delimiters.Right == 6);
        }

        [TestMethod]
        public void TestFinished()
        {
            Assert.IsFalse(delimiters.Finished);

            delimiters.Left = 3;
            delimiters.Right = 3;

            delimiters.Top = 2;
            delimiters.Bottom = 2;

            Assert.IsFalse(delimiters.Finished);
        }

        [TestMethod]
        public void TestNotFinished()
        {
            delimiters.Left = 4;
            delimiters.Right = 3;
            delimiters.Top = 2;
            delimiters.Bottom = 2;

            Assert.IsTrue(delimiters.Finished);

            delimiters.Left = 3;
            delimiters.Right = 3;
            delimiters.Top = 3;
            delimiters.Bottom = 2;

            Assert.IsTrue(delimiters.Finished);
        }
    }
}
