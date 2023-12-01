using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TolmachevVV.Sprint6.Task2.V25.Lib
{
    public class DataService : ISprint6Task2V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] output = new double[stopValue - startValue + 1];
            for (int x = startValue, i = 0; i < output.Length; i++, x++)
            {
                double result = Math.Round((5 * x + 2.5) / (Math.Sin(x) - 2) + 2, 2);
                if (!double.IsNaN(result))
                {
                    output[i] = result;
                }
                else
                {
                    output[i] = 0;
                }
            }
            return output;
        }
    }
}
