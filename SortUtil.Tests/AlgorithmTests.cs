using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortUtils.Tests
{
    [TestClass]
    public class AlgorithmTests
    {
        #region MergeSort Tests

        [TestMethod]
        public void MergeSort_TestArraySort_ExpectedArray()
        {
            int[] testArray = { 10, -7, 14, 4, 4, -8, 9, 7 };
            int[] expectedArray = { -8, -7, 4, 4, 7, 9, 10, 14 };

            Algorithm.MergeSort(testArray);
            CollectionAssert.AreEqual(expectedArray, testArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSort_Null_ArgumentNullException()
        {
            Algorithm.MergeSort(null);
        }

        #endregion

        #region QuickSort Tests

        [TestMethod]
        public void MergeSort_EmptyArray_EmptyArray()
        {
            int[] a = { };
            int[] b = { };
            Algorithm.MergeSort(a);
            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void QuickSort_TestArraySort_ExpectedArray()
        {
            int[] testArray = { 10, -7, 14, 4, 4, -8, 9, 7 };
            int[] expectedArray = { -8, -7, 4, 4, 7, 9, 10, 14 };

            Algorithm.QuickSort(testArray);
            CollectionAssert.AreEqual(expectedArray, testArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_Null_ArgumentNullException()
        {
            Algorithm.QuickSort(null);
        }

        #endregion
    }
}
