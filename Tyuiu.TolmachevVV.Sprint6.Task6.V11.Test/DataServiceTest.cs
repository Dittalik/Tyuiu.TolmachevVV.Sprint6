using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint6.Task6.V11.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ContextTest()
        {
            DataService service = new DataService();
            string testPath = @"C:\DataSprint5\InPutDataFileTask7V12.txt";
            Assert.AreEqual("заглавых", service.CollectTextFromFile("", testPath).ToLower());
        }
    }
}
