using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TolmachevVV.Sprint6.Task3.V20.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        DataService service = new DataService();
        int[,] matrix = { { -14, 17, -19, 3, 2   },
                              { -4, -14, -19, -9, -1 },
                              { 1, 0, 13, 14, 8      },
                              { 13, 7, 8, -3, -15    },
                              { 2, -20, 12, -14, 4   } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOutput.RowCount = matrix.GetLength(0);
            dataGridViewOutput.ColumnCount = matrix.GetLength(1);
            for (int i = 0; i < dataGridViewOutput.ColumnCount; i++)
            {
                dataGridViewOutput.Columns[i].Width = 25;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            matrix = service.Calculate(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб 23-1 Толмачев В. В.", "Справка");
        }
    }
}
