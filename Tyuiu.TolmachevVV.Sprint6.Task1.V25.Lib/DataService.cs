using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TolmachevVV.Sprint6.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutputDataFile.txt";
            string[] output = new string[(startValue < 0)? stopValue - startValue + 1 : stopValue - startValue];
            for (int x = startValue, i = 0; x <= stopValue; i++, x++)
            {
                double result = Math.Round((5 * x + 2.5) / (Math.Sin(x) - 2) + 2, 2);
                if (!double.IsNaN(result))
                {
                    output[i] = result.ToString();
                }
                else
                {
                    output[i] = "0";
                }
            }
            File.WriteAllText(path, String.Join("\t", output));
            return path;
        }
    }
}
