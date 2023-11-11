using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint4.Task6.V1.Lib;

namespace Tyuiu.KushnerovIA.Sprint4.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] myArray = { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };

            Assert.AreEqual(2, ds.Calculate(myArray));
        }
    }
}
