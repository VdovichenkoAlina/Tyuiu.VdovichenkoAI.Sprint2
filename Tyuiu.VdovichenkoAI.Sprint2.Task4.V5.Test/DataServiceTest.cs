using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VdovichenkoAI.Sprint2.Task4.V5.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 34.693;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 75.5;
            Assert.AreEqual(wait, res);
        }
    }
}
