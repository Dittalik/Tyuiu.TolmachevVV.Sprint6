using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint6.Task0.V18.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService service = new DataService();
            Assert.AreEqual(1.056, service.Calculate(3));
        }
    }
}
