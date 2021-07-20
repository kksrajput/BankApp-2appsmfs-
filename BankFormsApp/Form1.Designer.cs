
namespace BankFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BankName = new System.Windows.Forms.TextBox();
            this.BankId = new System.Windows.Forms.TextBox();
            this.BankAddress = new System.Windows.Forms.TextBox();
            this.BankZip = new System.Windows.Forms.TextBox();
            this.BankCity = new System.Windows.Forms.TextBox();
            this.BankState = new System.Windows.Forms.TextBox();
            this.BankEmail = new System.Windows.Forms.TextBox();
            this.btntest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BankName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BankId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "BankAddress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "BankZip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "BankCity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "BankState";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "BankEmail";
            // 
            // BankName
            // 
            this.BankName.Location = new System.Drawing.Point(225, 36);
            this.BankName.Name = "BankName";
            this.BankName.Size = new System.Drawing.Size(407, 27);
            this.BankName.TabIndex = 7;
            // 
            // BankId
            // 
            this.BankId.Location = new System.Drawing.Point(225, 83);
            this.BankId.Name = "BankId";
            this.BankId.Size = new System.Drawing.Size(407, 27);
            this.BankId.TabIndex = 8;
            // 
            // BankAddress
            // 
            this.BankAddress.Location = new System.Drawing.Point(225, 119);
            this.BankAddress.Name = "BankAddress";
            this.BankAddress.Size = new System.Drawing.Size(407, 27);
            this.BankAddress.TabIndex = 9;
            // 
            // BankZip
            // 
            this.BankZip.Location = new System.Drawing.Point(225, 166);
            this.BankZip.Name = "BankZip";
            this.BankZip.Size = new System.Drawing.Size(407, 27);
            this.BankZip.TabIndex = 10;
            // 
            // BankCity
            // 
            this.BankCity.Location = new System.Drawing.Point(225, 211);
            this.BankCity.Name = "BankCity";
            this.BankCity.Size = new System.Drawing.Size(407, 27);
            this.BankCity.TabIndex = 11;
            // 
            // BankState
            // 
            this.BankState.Location = new System.Drawing.Point(225, 255);
            this.BankState.Name = "BankState";
            this.BankState.Size = new System.Drawing.Size(407, 27);
            this.BankState.TabIndex = 12;
            // 
            // BankEmail
            // 
            this.BankEmail.Location = new System.Drawing.Point(225, 298);
            this.BankEmail.Name = "BankEmail";
            this.BankEmail.Size = new System.Drawing.Size(407, 27);
            this.BankEmail.TabIndex = 13;
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(250, 361);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(190, 29);
            this.btntest.TabIndex = 14;
            this.btntest.Text = "Test";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.BankEmail);
            this.Controls.Add(this.BankState);
            this.Controls.Add(this.BankCity);
            this.Controls.Add(this.BankZip);
            this.Controls.Add(this.BankAddress);
            this.Controls.Add(this.BankId);
            this.Controls.Add(this.BankName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BankName;
        private System.Windows.Forms.TextBox BankId;
        private System.Windows.Forms.TextBox BankAddress;
        private System.Windows.Forms.TextBox BankZip;
        private System.Windows.Forms.TextBox BankCity;
        private System.Windows.Forms.TextBox BankState;
        private System.Windows.Forms.TextBox BankEmail;
        private System.Windows.Forms.Button btntest;
    }
}

