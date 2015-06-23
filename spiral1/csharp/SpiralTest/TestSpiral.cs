using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SpiralTest
{
    /// <summary>
    /// Summary description for TestSpiral
    /// </summary>
    [TestClass]
    public class TestSpiral
    {
        private Spiral.Spiral spiral;

        public TestSpiral()
        {
            int[,] matriz = new int[2,2];

            /*
             * 0 1
             * 2 3
             */

            matriz[0, 0] = 0;
            matriz[0, 1] = 1;
            matriz[1, 0] = 2;
            matriz[1, 1] = 3;

            spiral = new Spiral.Spiral(matriz);
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
        public void TestGetSpiral()
        {
            int[] result = spiral.GetSpiral();
            int[] expected = new int[4] {0, 1, 3, 2};

            Assert.IsTrue(Enumerable.SequenceEqual<int>(result, expected));
        }
        
        [TestMethod]
        public void TestGetSpiral3x3()
        {
            /*
             * 3 5 4 
             * 9 5 5
             * 3 1 9
             */
            int [,] matriz = new int[,] { { 3,5,4 }, { 9,5,5}, { 3,1,9 } };
            spiral = new Spiral.Spiral(matriz);

            int[] result = spiral.GetSpiral();
            int[] expected = new int[] { 3, 5, 4, 5, 9, 1, 3, 9, 5 };

            Assert.IsTrue(Enumerable.SequenceEqual<int>(result, expected));
        }

        [TestMethod]
        public void TestGetSpiral4x4()
        {
            /*
             * 3 5 4 4
             * 9 5 5 3
             * 3 1 9 2 
             * 1 2 3 4
             */
            int[,] matriz = new int[,] { { 3, 5, 4, 4 }, { 9, 5, 5, 3 }, { 3, 1, 9, 2 }, {1, 2, 3, 4 }};
            spiral = new Spiral.Spiral(matriz);

            int[] result = spiral.GetSpiral();
            int[] expected = new int[] { 3, 5, 4, 4, 3, 2, 4, 3, 2, 1, 3, 9, 5, 5, 9, 1 };

            Assert.IsTrue(Enumerable.SequenceEqual<int>(result, expected));
        }

    }
}
 