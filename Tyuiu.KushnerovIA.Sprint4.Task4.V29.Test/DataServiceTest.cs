using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint4.Task4.V29.Lib;

namespace Tyuiu.KushnerovIA.Sprint4.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] ar = { { 5, 6, 5, 6, 5 },
                          { 5, 5, 5, 8, 4 },
                          { 8, 5, 5, 8, 8 },
                          { 6, 5, 4, 4, 8 },
                          { 8, 5, 6, 8, 8 } };
            Assert.AreEqual(100, ds.Calculate(ar));
        }
    }
}
