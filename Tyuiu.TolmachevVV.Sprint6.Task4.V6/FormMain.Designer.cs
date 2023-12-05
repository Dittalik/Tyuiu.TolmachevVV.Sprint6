
namespace Tyuiu.TolmachevVV.Sprint6.Task4.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxInputTo = new System.Windows.Forms.TextBox();
            this.textBoxInputFrom = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.pictureBox1);
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(329, 82);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Tyuiu.TolmachevVV.Sprint6.Task4.V6.Properties.Resources.ConditionTask41;
            this.pictureBox1.Location = new System.Drawing.Point(6, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition.Location = new System.Drawing.Point(6, 19);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(284, 33);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Вывести таблицу значений функции в диапазоне [-5; 5]";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelTo);
            this.groupBoxInput.Controls.Add(this.labelFrom);
            this.groupBoxInput.Controls.Add(this.textBoxInputTo);
            this.groupBoxInput.Controls.Add(this.textBoxInputFrom);
            this.groupBoxInput.Location = new System.Drawing.Point(348, 13);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(122, 82);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(59, 33);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 13);
            this.labelTo.TabIndex = 1;
            this.labelTo.Text = "До:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(6, 33);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(23, 13);
            this.labelFrom.TabIndex = 1;
            this.labelFrom.Text = "От:";
            // 
            // textBoxInputTo
            // 
            this.textBoxInputTo.Location = new System.Drawing.Point(62, 49);
            this.textBoxInputTo.Name = "textBoxInputTo";
            this.textBoxInputTo.Size = new System.Drawing.Size(49, 20);
            this.textBoxInputTo.TabIndex = 0;
            this.textBoxInputTo.Text = "5";
            // 
            // textBoxInputFrom
            // 
            this.textBoxInputFrom.Location = new System.Drawing.Point(7, 49);
            this.textBoxInputFrom.Name = "textBoxInputFrom";
            this.textBoxInputFrom.Size = new System.Drawing.Size(49, 20);
            this.textBoxInputFrom.TabIndex = 0;
            this.textBoxInputFrom.Text = "-5";
            this.textBoxInputFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputFrom_KeyPress);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.chartFunction);
            this.groupBoxOutput.Controls.Add(this.textBoxOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(13, 102);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(457, 283);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод Данных";
            // 
            // chartFunction
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction.Legends.Add(legend3);
            this.chartFunction.Location = new System.Drawing.Point(70, 20);
            this.chartFunction.Name = "chartFunction";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction.Series.Add(series3);
            this.chartFunction.Size = new System.Drawing.Size(376, 250);
            this.chartFunction.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutput.Location = new System.Drawing.Point(7, 20);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(57, 250);
            this.textBoxOutput.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(20, 391);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(91, 50);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(117, 391);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(91, 50);
            this.buttonExecute.TabIndex = 3;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(214, 391);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 50);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxCondition);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 6 | Task 4 | V6 | Tolmachev V. V.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxInputTo;
        private System.Windows.Forms.TextBox textBoxInputFrom;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonSave;
    }
}

