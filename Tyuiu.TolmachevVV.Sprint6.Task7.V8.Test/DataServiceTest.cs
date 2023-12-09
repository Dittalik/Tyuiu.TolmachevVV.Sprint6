using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint6.Task7.V8.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MatrixTest()
        {
            DataService service = new DataService();

            int[,] testMatrix = new int[9, 9];
            for (int i = 0; i < testMatrix.GetLength(0); i++)
            {
                testMatrix[i, 8] = -1;
            }
            int[,] testMatrix1 = new int[9, 9];
            CollectionAssert.AreEqual(testMatrix1, service.GetMatrix(testMatrix1));
        }
    }
}
