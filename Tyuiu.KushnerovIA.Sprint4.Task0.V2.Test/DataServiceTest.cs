using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint4.Task0.V2.Lib;

namespace Tyuiu.KushnerovIA.Sprint4.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 1, 3, 6, 2, 6, 2, 5, 5, 6, 2 };
            int res = ds.GetSumOddArrEl(array), wait = 14;
            Assert.AreEqual(res, wait);
        }
    }
}
