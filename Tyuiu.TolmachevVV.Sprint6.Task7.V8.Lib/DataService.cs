using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TolmachevVV.Sprint6.Task7.V8.Lib
{
    public class DataService : ISprint6Task7V8  
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               if (matrix [i, 8] != 5)
                {
                    matrix[i, 8] = -1;
                }
            }
            return matrix;
        }
    }
}
