
namespace Tyuiu.TolmachevVV.Sprint6.Task3.V20
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
            this.pictureBoxCondition = new System.Windows.Forms.PictureBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.pictureBoxCondition);
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(160, 241);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // pictureBoxCondition
            // 
            this.pictureBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCondition.Image = global::Tyuiu.TolmachevVV.Sprint6.Task3.V20.Properties.Resources.MatrixTask3;
            this.pictureBoxCondition.Location = new System.Drawing.Point(17, 79);
            this.pictureBoxCondition.Name = "pictureBoxCondition";
            this.pictureBoxCondition.Size = new System.Drawing.Size(128, 148);
            this.pictureBoxCondition.TabIndex = 1;
            this.pictureBoxCondition.TabStop = false;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition.Location = new System.Drawing.Point(17, 19);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(128, 54);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.";
            // 
            // buttonExecute
            // 
            this.buttonExecute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExecute.Location = new System.Drawing.Point(201, 147);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(125, 50);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.AllowUserToAddRows = false;
            this.dataGridViewOutput.AllowUserToDeleteRows = false;
            this.dataGridViewOutput.AllowUserToResizeColumns = false;
            this.dataGridViewOutput.AllowUserToResizeRows = false;
            this.dataGridViewOutput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOutput.ColumnHeadersVisible = false;
            this.dataGridViewOutput.Location = new System.Drawing.Point(201, 31);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.ReadOnly = true;
            this.dataGridViewOutput.RowHeadersVisible = false;
            this.dataGridViewOutput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOutput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewOutput.Size = new System.Drawing.Size(125, 110);
            this.dataGridViewOutput.TabIndex = 2;
            // 
            // buttonHelp
            // 
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHelp.Location = new System.Drawing.Point(201, 203);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(125, 50);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.dataGridViewOutput);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.groupBoxCondition);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 6 | Task 2 | V25 | Tolmachev V. V.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.PictureBox pictureBoxCondition;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.Button buttonHelp;
    }
}

