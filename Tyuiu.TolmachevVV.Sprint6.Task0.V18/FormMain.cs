using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TolmachevVV.Sprint6.Task0.V18.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task0.V18
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        DataService service = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResultCaclulation_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = service.Calculate(3).ToString();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ПКТб 23-1 Толмачев В. В.", "Сообщение");
        }
    }
}
