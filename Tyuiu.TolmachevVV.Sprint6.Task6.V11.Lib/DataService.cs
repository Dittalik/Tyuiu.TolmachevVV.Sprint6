using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TolmachevVV.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string str, string path)
        {
            string[] content = File.ReadAllLines(path);
            str = "";
            foreach(string line in content)
            {
                if (line.Split(' ').Length > 1)
                {
                    str += line.Split(' ')[line.Split(' ').Length - 2] + " ";
                }
                else
                {
                    str += line.Split(' ')[0];
                }
            }
            return str;
        }
    }
}
