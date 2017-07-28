using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleAreaSearcherLib;

namespace TriangleAreaSearcher.Tests
{
    [TestClass]
    public class SearcherTests
    {
        [TestMethod]
        public void SearchAreaTest()
        {
            Assert.AreEqual(Searcher.SearchArea(3, 4, 5), 6);
            Assert.AreEqual(Searcher.SearchArea(3.0, 4.0, 5.0), 6.0);
        }

        [TestMethod]
        public void DataAreCorrectTest()
        {
            Assert.IsTrue(Searcher.DataAreCorrect(3, 4, 5));
            Assert.IsFalse(Searcher.DataAreCorrect(-3, 4, 5));
            Assert.IsFalse(Searcher.DataAreCorrect(3, 4, 0));
            Assert.IsTrue(Searcher.DataAreCorrect(0.1, 0.01, 0.00000001));
        }

        [TestMethod]
        public void TriangleIsRightTest()
        {
            Assert.IsTrue(Searcher.TriangleIsRight(3, 4, 5));
            Assert.IsFalse(Searcher.TriangleIsRight(3, 9, 9));
            Assert.IsFalse(Searcher.TriangleIsRight(-3, 0, 2));
            
        }
    }
}
