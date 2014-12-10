namespace InterestCalculator_App
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
            this.selectbank = new System.Windows.Forms.ComboBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.banklist = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelInterest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectbank
            // 
            this.selectbank.FormattingEnabled = true;
            this.selectbank.Items.AddRange(new object[] {
            "Brac",
            "DBBL",
            "HSCB"});
            this.selectbank.Location = new System.Drawing.Point(125, 49);
            this.selectbank.Name = "selectbank";
            this.selectbank.Size = new System.Drawing.Size(121, 21);
            this.selectbank.TabIndex = 0;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(125, 210);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(100, 20);
            this.textResult.TabIndex = 1;
            this.textResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(125, 89);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(100, 20);
            this.textTime.TabIndex = 2;
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(125, 129);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(100, 20);
            this.textBalance.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate Interest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // banklist
            // 
            this.banklist.AutoSize = true;
            this.banklist.Location = new System.Drawing.Point(27, 49);
            this.banklist.Name = "banklist";
            this.banklist.Size = new System.Drawing.Size(63, 13);
            this.banklist.TabIndex = 5;
            this.banklist.Text = "Bank Name";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(27, 96);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(73, 13);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Time(in yeaar)";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(30, 136);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(47, 13);
            this.labelBalance.TabIndex = 7;
            this.labelBalance.Text = "Principle";
            // 
            // labelInterest
            // 
            this.labelInterest.AutoSize = true;
            this.labelInterest.Location = new System.Drawing.Point(30, 217);
            this.labelInterest.Name = "labelInterest";
            this.labelInterest.Size = new System.Drawing.Size(42, 13);
            this.labelInterest.TabIndex = 8;
            this.labelInterest.Text = "Interest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelInterest);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.banklist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.selectbank);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectbank;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label banklist;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelInterest;
    }
}

