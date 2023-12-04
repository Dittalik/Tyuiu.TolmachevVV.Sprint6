using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint6.Task4.V6.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationTest()
        {
            DataService service = new DataService();
            CollectionAssert.AreEqual(new double[] { 23.92, 18.88, 13.1, 7.24, 1.8, -8, -5.7, -11.26, -17.12, -22.88, -27.92 }, service.GetMassFunction(-5, 5));
        }
    }
}
