﻿namespace SquareValue_App
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
            this.aNumberText = new System.Windows.Forms.Label();
            this.twoTimeNumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aNumberText
            // 
            this.aNumberText.AutoSize = true;
            this.aNumberText.Location = new System.Drawing.Point(32, 42);
            this.aNumberText.Name = "aNumberText";
            this.aNumberText.Size = new System.Drawing.Size(54, 13);
            this.aNumberText.TabIndex = 0;
            this.aNumberText.Text = "A Number";
            this.aNumberText.Click += new System.EventHandler(this.label1_Click);
            // 
            // twoTimeNumber
            // 
            this.twoTimeNumber.AutoSize = true;
            this.twoTimeNumber.Location = new System.Drawing.Point(32, 112);
            this.twoTimeNumber.Name = "twoTimeNumber";
            this.twoTimeNumber.Size = new System.Drawing.Size(89, 13);
            this.twoTimeNumber.TabIndex = 1;
            this.twoTimeNumber.Text = "Two Times Value";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(69, 178);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(131, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show Two Time";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.twoTimeNumber);
            this.Controls.Add(this.aNumberText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aNumberText;
        private System.Windows.Forms.Label twoTimeNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button showButton;
    }
}

