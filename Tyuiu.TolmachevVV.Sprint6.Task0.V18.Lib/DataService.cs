using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TolmachevVV.Sprint6.Task0.V18.Lib
{
    public class DataService : ISprint6Task0V18
    {
        public double Calculate(int x)
        {
            return Math.Round((Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)), 3);
        }
    }
}
