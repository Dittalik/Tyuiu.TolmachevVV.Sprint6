using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TolmachevVV.Sprint6.Task1.V25.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService service = new DataService();
        [TestMethod]
        public void FileExistenceTest()
        {
            FileInfo fileInfo = new FileInfo(service.SaveToFileTextData(-1, 1));
            Assert.IsTrue(fileInfo.Exists);
        }
        [TestMethod]
        public void DataTest()
        {
            double[] TestArray = new double[] { 23.61, 16.08, 7.84, 4.58, 2.88, 0.75, -4.47, -9.46, -7.41, -6.16, -7.29 };
            CollectionAssert.AreEqual(TestArray, Array.ConvertAll(File.ReadAllText(service.SaveToFileTextData(-5, 5)).Split('\t'), x => Convert.ToDouble(x)));
        }
    }
}
