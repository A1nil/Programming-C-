namespace account.cs
{
    partial class Form2
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
            this.Account1 = new System.Windows.Forms.Label();
            this.Account2 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.textAccount1 = new System.Windows.Forms.TextBox();
            this.textAccount2 = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Account1
            // 
            this.Account1.AutoSize = true;
            this.Account1.Location = new System.Drawing.Point(29, 33);
            this.Account1.Name = "Account1";
            this.Account1.Size = new System.Drawing.Size(53, 13);
            this.Account1.TabIndex = 0;
            this.Account1.Text = "Account1";
            // 
            // Account2
            // 
            this.Account2.AutoSize = true;
            this.Account2.Location = new System.Drawing.Point(32, 130);
            this.Account2.Name = "Account2";
            this.Account2.Size = new System.Drawing.Size(53, 13);
            this.Account2.TabIndex = 1;
            this.Account2.Text = "Account2";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(208, 83);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 2;
            this.Amount.Text = "Amount";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(110, 179);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 3;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // textAccount1
            // 
            this.textAccount1.Location = new System.Drawing.Point(84, 29);
            this.textAccount1.Name = "textAccount1";
            this.textAccount1.Size = new System.Drawing.Size(100, 20);
            this.textAccount1.TabIndex = 4;
            // 
            // textAccount2
            // 
            this.textAccount2.Location = new System.Drawing.Point(84, 127);
            this.textAccount2.Name = "textAccount2";
            this.textAccount2.Size = new System.Drawing.Size(100, 20);
            this.textAccount2.TabIndex = 5;
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(259, 81);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(100, 20);
            this.textAmount.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 222);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textAccount2);
            this.Controls.Add(this.textAccount1);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Account2);
            this.Controls.Add(this.Account1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Account1;
        private System.Windows.Forms.Label Account2;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox textAccount1;
        private System.Windows.Forms.TextBox textAccount2;
        private System.Windows.Forms.TextBox textAmount;
    }
}