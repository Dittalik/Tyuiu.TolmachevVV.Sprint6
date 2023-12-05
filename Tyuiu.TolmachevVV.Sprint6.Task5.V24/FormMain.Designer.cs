
namespace Tyuiu.TolmachevVV.Sprint6.Task5.V24
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOpenData = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBox1);
            this.groupBoxCondition.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(271, 80);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(256, 60);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V24.txt. Вывести в dataGridView.Дан списо" +
    "к из чисел. Вывести все элементы, равные 0. Построить диаграмму по этим значения" +
    "м.";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.ColumnHeadersVisible = false;
            this.dataGridViewData.Location = new System.Drawing.Point(13, 100);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersVisible = false;
            this.dataGridViewData.Size = new System.Drawing.Size(124, 251);
            this.dataGridViewData.TabIndex = 1;
            // 
            // chartData
            // 
            chartArea4.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartData.Legends.Add(legend4);
            this.chartData.Location = new System.Drawing.Point(143, 100);
            this.chartData.Name = "chartData";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartData.Series.Add(series4);
            this.chartData.Size = new System.Drawing.Size(339, 251);
            this.chartData.TabIndex = 2;
            this.chartData.Text = "chart1";
            // 
            // buttonOpenData
            // 
            this.buttonOpenData.Location = new System.Drawing.Point(290, 66);
            this.buttonOpenData.Name = "buttonOpenData";
            this.buttonOpenData.Size = new System.Drawing.Size(72, 27);
            this.buttonOpenData.TabIndex = 3;
            this.buttonOpenData.Text = "Открыть";
            this.buttonOpenData.UseVisualStyleBackColor = true;
            this.buttonOpenData.Click += new System.EventHandler(this.buttonOpenData_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(290, 33);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(72, 27);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(368, 33);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(114, 60);
            this.buttonExecute.TabIndex = 3;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 361);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOpenData);
            this.Controls.Add(this.chartData);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.groupBoxCondition);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 6 | Task5 | V24 | Tolmachev V. V.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.Button buttonOpenData;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExecute;
    }
}

