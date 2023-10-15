using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VdovichenkoAI.Sprint2.Task7.V14.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 0;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
