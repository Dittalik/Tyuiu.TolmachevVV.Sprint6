using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TolmachevVV.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V3
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[4, i] % 2 == 0)
                    matrix[4, i] = 0;
            }
            return matrix;
        }
    }
}
