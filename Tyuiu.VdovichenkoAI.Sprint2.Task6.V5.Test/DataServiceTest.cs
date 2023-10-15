using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VdovichenkoAI.Sprint2.Task6.V5.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardValue()
        {
            DataService ds = new DataService();
            int value = 7;
            string res = ds.FindCardValue(value);
            string wait = "семерка";
            Assert.AreEqual(wait, res);
        }
    }
}
