
namespace Tyuiu.TolmachevVV.Sprint6.Task1.V25
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
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.textBoxOutputData = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBoxFunction = new System.Windows.Forms.PictureBox();
            this.groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.pictureBoxFunction);
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 21);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(264, 138);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxCondition.Location = new System.Drawing.Point(6, 19);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(121, 52);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Вывести таблицу значений заданной функции в диапазоне [-5; 5].";
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp.Location = new System.Drawing.Point(12, 179);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(104, 63);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonResult.Location = new System.Drawing.Point(123, 179);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(153, 63);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // textBoxOutputData
            // 
            this.textBoxOutputData.AcceptsTab = true;
            this.textBoxOutputData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxOutputData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutputData.Location = new System.Drawing.Point(302, 21);
            this.textBoxOutputData.Multiline = true;
            this.textBoxOutputData.Name = "textBoxOutputData";
            this.textBoxOutputData.ReadOnly = true;
            this.textBoxOutputData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutputData.Size = new System.Drawing.Size(173, 254);
            this.textBoxOutputData.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(308, 5);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат";
            // 
            // pictureBoxFunction
            // 
            this.pictureBoxFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFunction.Image = global::Tyuiu.TolmachevVV.Sprint6.Task1.V25.Properties.Resources.CalculationTask11;
            this.pictureBoxFunction.InitialImage = null;
            this.pictureBoxFunction.Location = new System.Drawing.Point(6, 77);
            this.pictureBoxFunction.Name = "pictureBoxFunction";
            this.pictureBoxFunction.Size = new System.Drawing.Size(193, 41);
            this.pictureBoxFunction.TabIndex = 1;
            this.pictureBoxFunction.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 287);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxOutputData);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxCondition);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 6 | Task 1 | V25 | Tolmachev V. V.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.PictureBox pictureBoxFunction;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox textBoxOutputData;
        private System.Windows.Forms.Label labelResult;
    }
}

