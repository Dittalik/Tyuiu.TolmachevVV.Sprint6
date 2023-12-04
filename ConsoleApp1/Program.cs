using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint6.Task4.V6.Lib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service = new DataService();
            double[] ar = service.GetMassFunction(-5, 5);
            Console.Write(String.Join(" ", ar));
            Console.ReadKey();
        }
    }
}
