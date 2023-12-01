
namespace Tyuiu.TolmachevVV.Sprint6.Task2.V25
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.dataGridViewFunctionOutput = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.numericUpDownStopInput = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartInput = new System.Windows.Forms.NumericUpDown();
            this.buttonResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctionOutput)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStopInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.pictureBox1);
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(39, 26);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(246, 122);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Tyuiu.TolmachevVV.Sprint6.Task2.V25.Properties.Resources.CalculationTask2;
            this.pictureBox1.Location = new System.Drawing.Point(7, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 39);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition.Location = new System.Drawing.Point(7, 20);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(201, 50);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Вывести таблицу значений заданной функции в диапазоне [-5; 5].";
            // 
            // dataGridViewFunctionOutput
            // 
            this.dataGridViewFunctionOutput.AllowUserToAddRows = false;
            this.dataGridViewFunctionOutput.AllowUserToDeleteRows = false;
            this.dataGridViewFunctionOutput.AllowUserToResizeColumns = false;
            this.dataGridViewFunctionOutput.AllowUserToResizeRows = false;
            this.dataGridViewFunctionOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunctionOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Function});
            this.dataGridViewFunctionOutput.Location = new System.Drawing.Point(313, 26);
            this.dataGridViewFunctionOutput.Name = "dataGridViewFunctionOutput";
            this.dataGridViewFunctionOutput.ReadOnly = true;
            this.dataGridViewFunctionOutput.RowHeadersVisible = false;
            this.dataGridViewFunctionOutput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewFunctionOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFunctionOutput.Size = new System.Drawing.Size(202, 300);
            this.dataGridViewFunctionOutput.TabIndex = 1;
            // 
            // X
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.X.DefaultCellStyle = dataGridViewCellStyle5;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Function
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Function.DefaultCellStyle = dataGridViewCellStyle6;
            this.Function.HeaderText = "F(X)";
            this.Function.Name = "Function";
            this.Function.ReadOnly = true;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.numericUpDownStopInput);
            this.groupBoxInput.Controls.Add(this.numericUpDownStartInput);
            this.groupBoxInput.Controls.Add(this.buttonResult);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Location = new System.Drawing.Point(39, 172);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(246, 87);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // numericUpDownStopInput
            // 
            this.numericUpDownStopInput.Location = new System.Drawing.Point(86, 54);
            this.numericUpDownStopInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStopInput.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownStopInput.Name = "numericUpDownStopInput";
            this.numericUpDownStopInput.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownStopInput.TabIndex = 4;
            // 
            // numericUpDownStartInput
            // 
            this.numericUpDownStartInput.Location = new System.Drawing.Point(7, 55);
            this.numericUpDownStartInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStartInput.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownStartInput.Name = "numericUpDownStartInput";
            this.numericUpDownStartInput.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownStartInput.TabIndex = 4;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(164, 19);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(76, 58);
            this.buttonResult.TabIndex = 3;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            this.buttonResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_MouseDown);
            this.buttonResult.MouseEnter += new System.EventHandler(this.buttonResult_MouseEnter);
            this.buttonResult.MouseLeave += new System.EventHandler(this.buttonResult_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "До:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "От:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Диапазон:";
            // 
            // chartFunction
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction.Legends.Add(legend3);
            this.chartFunction.Location = new System.Drawing.Point(521, 26);
            this.chartFunction.Name = "chartFunction";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.LabelForeColor = System.Drawing.Color.Transparent;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction.Series.Add(series3);
            this.chartFunction.Size = new System.Drawing.Size(348, 300);
            this.chartFunction.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 367);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.dataGridViewFunctionOutput);
            this.Controls.Add(this.groupBoxCondition);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 6 | Task 2 | V25 | Tolmachev V. V.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctionOutput)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStopInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewFunctionOutput;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownStopInput;
        private System.Windows.Forms.NumericUpDown numericUpDownStartInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}

