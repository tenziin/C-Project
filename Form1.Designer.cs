﻿namespace Assessment1a
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstNo = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.btnSubtract);
            this.groupBox1.Controls.Add(this.txtSecondNumber);
            this.groupBox1.Controls.Add(this.txtFirstNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(100, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assessment 1- Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the first Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the second number";
            // 
            // txtFirstNo
            // 
            this.txtFirstNo.Location = new System.Drawing.Point(225, 49);
            this.txtFirstNo.Name = "txtFirstNo";
            this.txtFirstNo.Size = new System.Drawing.Size(299, 22);
            this.txtFirstNo.TabIndex = 2;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(225, 82);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(299, 22);
            this.txtSecondNumber.TabIndex = 3;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(104, 148);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(114, 48);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(30, 227);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(286, 22);
            this.txtResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtFirstNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
    }
}

