using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint4.Task5.V12.Lib;

namespace Tyuiu.KushnerovIA.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] testArray = new int[,] { { 0, -5, 2, -7 }, { 5, -1, 3, 0 }, { 7, -2, -11, 1 } };

            Assert.AreEqual(5, ds.Calculate(testArray));
        }
    }
}
