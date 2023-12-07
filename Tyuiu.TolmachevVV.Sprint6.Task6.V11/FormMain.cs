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
using Tyuiu.TolmachevVV.Sprint6.Task6.V11.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService service = new DataService();
        string filePath;
        private void buttonFileInput_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            filePath = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(filePath);
            groupBoxInput.Text += " " + filePath;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOutput.Text = service.CollectTextFromFile("", filePath);
            }
            catch
            {
               MessageBox.Show("Некорректный путь к файлу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
