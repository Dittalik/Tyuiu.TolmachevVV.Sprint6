using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.TolmachevVV.Sprint6.Task1.V25.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task1.V25
{
    public partial class FormMain : Form
    {
        DataService service = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб 23-1 Толмачев В. В.", "Справка");
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            double[] values = Array.ConvertAll(File.ReadAllText(service.SaveToFileTextData(-5, 5)).Split('\t'), x => Convert.ToDouble(x));
            string line;

            textBoxOutputData.Text = "";
            textBoxOutputData.AppendText("+----------+----------+" + Environment.NewLine);
            textBoxOutputData.AppendText("|     X    |    f(x)  |" + Environment.NewLine);
            textBoxOutputData.AppendText("+----------+----------+" + Environment.NewLine);
            for (int i = 0, x = -5; i < values.Length; i++, x++)
            {
                line = String.Format("|{0,5:d}     |   {1, 5:f2}  |", x, values[i]);
                textBoxOutputData.AppendText(line + Environment.NewLine);
            }
            textBoxOutputData.AppendText("+----------+----------+" + Environment.NewLine);
        }
    }
}
