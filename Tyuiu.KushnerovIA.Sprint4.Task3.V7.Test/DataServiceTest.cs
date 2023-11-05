using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint4.Task3.V7.Lib;

namespace Tyuiu.KushnerovIA.Sprint4.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] arrayNums = new int[5, 5] { { 9, 6, 9, 3, 7 },
                                               { 3, 3, 3, 8, 2 },
                                               { 2, 1, 3, 5, 2 },
                                               { 6, 2, 3, 2, 5 },
                                               { 4, 5, 6, 9, 5 } };
            int res = ds.Calculate(arrayNums);
            int wait = 15;

            Assert.AreEqual(wait, res);

        }
    }
}
