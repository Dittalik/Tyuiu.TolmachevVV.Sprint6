using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TolmachevVV.Sprint6.Task2.V25.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task2.V25
{
    public partial class FormMain : Form
    {
        DataService service = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {

                chartFunction.Series[0].Points.Clear();
                dataGridViewFunctionOutput.Rows.Clear();
                chartFunction.Titles.Clear();

                chartFunction.Titles.Add("График функции F(x)");

                chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                int startValue = Convert.ToInt32(numericUpDownStartInput.Value);
                int stopValue = Convert.ToInt32(numericUpDownStopInput.Value);
                double[] values = service.GetMassFunction(startValue, stopValue);
                for (int i = startValue, j = 0; i <= stopValue; i++, j++)
                {
                    dataGridViewFunctionOutput.Rows.Add(i.ToString(), values[j]);
                    chartFunction.Series[0].Points.AddXY(i, values[j]);
                }
            }
            catch
            {
                MessageBox.Show("Введен неправильный диапазон", "Ошибка");
            }
        }

        private void buttonResult_MouseEnter(object sender, EventArgs e)
        {
            buttonResult.BackColor = SystemColors.ButtonShadow;
        }

        private void buttonResult_MouseLeave(object sender, EventArgs e)
        {
            buttonResult.UseVisualStyleBackColor = true;
        }

        private void buttonResult_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult.FlatStyle = FlatStyle.Standard;
        }
    }
}
