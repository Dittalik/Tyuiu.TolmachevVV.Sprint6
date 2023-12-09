
namespace Tyuiu.TolmachevVV.Sprint6.Task7.V8
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxKassadin = new System.Windows.Forms.PictureBox();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKassadin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKassadin
            // 
            this.pictureBoxKassadin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKassadin.Image")));
            this.pictureBoxKassadin.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxKassadin.Name = "pictureBoxKassadin";
            this.pictureBoxKassadin.Size = new System.Drawing.Size(220, 239);
            this.pictureBoxKassadin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKassadin.TabIndex = 1;
            this.pictureBoxKassadin.TabStop = false;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.AcceptsReturn = true;
            this.textBoxAbout.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout.CausesValidation = false;
            this.textBoxAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxAbout.Location = new System.Drawing.Point(251, 75);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.ReadOnly = true;
            this.textBoxAbout.Size = new System.Drawing.Size(235, 91);
            this.textBoxAbout.TabIndex = 2;
            this.textBoxAbout.Text = "Разработчик: Толмачев Виталий Владимирович.\r\nГруппа: ПКТб 23-1.\r\nПрограмма разраб" +
    "отана вне рамок.\r\n\r\nТИУ.\r\nВШЦТ.";
            // 
            // buttonOK
            // 
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOK.Location = new System.Drawing.Point(411, 226);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 261);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.pictureBoxKassadin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 300);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKassadin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKassadin;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.Button buttonOK;
    }
}