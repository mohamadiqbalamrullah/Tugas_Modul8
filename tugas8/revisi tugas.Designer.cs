﻿namespace tugas8
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBox1.Location = new System.Drawing.Point(65, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IDR to USD",
            "IDR to SGD",
            "IDR to AUD",
            "USD to IDR",
            "SGD to IDR",
            "AUD to IDR"});
            this.comboBox1.Location = new System.Drawing.Point(65, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBox2.Location = new System.Drawing.Point(65, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BLASTIMO SANS", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(70, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 115);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOLLARIOUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "FARREL AHMAD YUDITHIA\r\nMOHAMAD IQBAL AMRULLAH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "KONVERSI MATA UANG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "1 IDR = 0.000066 USD ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "1 IDR = 0.00010 AUD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "1 IDR = 0.000093 SGD ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "1 SGD = 10772.10 IDR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "1 AUD = 9810.31 IDR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "1 USD = 15255 IDR ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(498, 282);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

