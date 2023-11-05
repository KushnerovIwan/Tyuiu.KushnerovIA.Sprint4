﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint4.Task2.V16.Lib;

namespace Tyuiu.KushnerovIA.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 3, 4, 5, 6, 7, 8, 9, 8, 9, 9 };
            int res = ds.Calculate(array), wait = 42;
            Assert.AreEqual(res, wait);
        }
    }
}
