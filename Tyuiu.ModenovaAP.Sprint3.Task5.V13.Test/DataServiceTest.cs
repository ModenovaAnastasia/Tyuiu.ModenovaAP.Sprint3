using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint3.Task5.V13.Lib;

namespace Tyuiu.ModenovaAP.Sprint3.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService data = new DataService();

            int x = 5;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 12;

            double res = data.GetSumSumSeries(x, start1, start2, stop1, stop2);

            double wait = 118.212;
            Assert.AreEqual(wait, res);
        }
    }
}
