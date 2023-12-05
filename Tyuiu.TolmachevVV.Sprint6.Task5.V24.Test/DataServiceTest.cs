using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint6.Task5.V24.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromFileTest()
        {
            string path = @"C:\DataSprint5\InPutFileTask5V24.txt";
            DataService service = new DataService();
            CollectionAssert.AreEqual(new double[] { 1, 17 }, service.LoadFromDataFile(path));
        }
    }
}
