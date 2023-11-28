
namespace Tyuiu.TolmachevVV.Sprint6.Task0.V18
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxReusltName = new System.Windows.Forms.TextBox();
            this.buttonResultCaclulation = new System.Windows.Forms.Button();
            this.groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.pictureBoxCondition);
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(303, 167);
            this.groupBoxCondition.TabIndex = 1;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // pictureBoxCondition
            // 
            this.pictureBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCondition.Image = global::Tyuiu.TolmachevVV.Sprint6.Task0.V18.Properties.Resources.Calculation;
            this.pictureBoxCondition.Location = new System.Drawing.Point(180, 19);
            this.pictureBoxCondition.Name = "pictureBoxCondition";
            this.pictureBoxCondition.Size = new System.Drawing.Size(117, 72);
            this.pictureBoxCondition.TabIndex = 0;
            this.pictureBoxCondition.TabStop = false;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition.Location = new System.Drawing.Point(17, 19);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(157, 137);
            this.textBoxCondition.TabIndex = 2;
            this.textBoxCondition.Text = "Посчитать значение выражения при x = 3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonResultCaclulation);
            this.groupBox1.Controls.Add(this.textBoxReusltName);
            this.groupBox1.Controls.Add(this.textBoxResult);
            this.groupBox1.Location = new System.Drawing.Point(321, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            this.textBoxResult.AccessibleDescription = "";
            this.textBoxResult.Location = new System.Drawing.Point(6, 39);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(85, 20);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.Tag = "";
            // 
            // textBoxReusltName
            // 
            this.textBoxReusltName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxReusltName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReusltName.Location = new System.Drawing.Point(6, 22);
            this.textBoxReusltName.Name = "textBoxReusltName";
            this.textBoxReusltName.Size = new System.Drawing.Size(56, 13);
            this.textBoxReusltName.TabIndex = 1;
            this.textBoxReusltName.Text = "Результат";
            // 
            // buttonResultCaclulation
            // 
            this.buttonResultCaclulation.Location = new System.Drawing.Point(6, 62);
            this.buttonResultCaclulation.Name = "buttonResultCaclulation";
            this.buttonResultCaclulation.Size = new System.Drawing.Size(85, 23);
            this.buttonResultCaclulation.TabIndex = 2;
            this.buttonResultCaclulation.Text = "Выполнить";
            this.buttonResultCaclulation.UseVisualStyleBackColor = true;
            this.buttonResultCaclulation.Click += new System.EventHandler(this.buttonResultCaclulation_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 190);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCondition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 6 | Task 0 | V18 | Tolmachev V. V.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.PictureBox pictureBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonResultCaclulation;
        private System.Windows.Forms.TextBox textBoxReusltName;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

