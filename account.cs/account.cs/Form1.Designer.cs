namespace account.cs
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
            this.Account_no = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.Label();
            this.Bank = new System.Windows.Forms.Label();
            this.textAccount_no = new System.Windows.Forms.TextBox();
            this.textType = new System.Windows.Forms.TextBox();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.textEmployee = new System.Windows.Forms.TextBox();
            this.textBank = new System.Windows.Forms.TextBox();
            this.INSERT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Account_no
            // 
            this.Account_no.AutoSize = true;
            this.Account_no.Location = new System.Drawing.Point(46, 25);
            this.Account_no.Name = "Account_no";
            this.Account_no.Size = new System.Drawing.Size(65, 13);
            this.Account_no.TabIndex = 0;
            this.Account_no.Text = "Account_no";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(45, 67);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 1;
            this.Type.Text = "Type";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(45, 112);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(46, 13);
            this.Balance.TabIndex = 2;
            this.Balance.Text = "Balance";
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Location = new System.Drawing.Point(45, 156);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(53, 13);
            this.Employee.TabIndex = 3;
            this.Employee.Text = "Employee";
            // 
            // Bank
            // 
            this.Bank.AutoSize = true;
            this.Bank.Location = new System.Drawing.Point(45, 201);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(32, 13);
            this.Bank.TabIndex = 4;
            this.Bank.Text = "Bank";
            // 
            // textAccount_no
            // 
            this.textAccount_no.Location = new System.Drawing.Point(115, 23);
            this.textAccount_no.Name = "textAccount_no";
            this.textAccount_no.Size = new System.Drawing.Size(100, 20);
            this.textAccount_no.TabIndex = 5;
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(115, 66);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(100, 20);
            this.textType.TabIndex = 6;
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(115, 110);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(100, 20);
            this.textBalance.TabIndex = 7;
            // 
            // textEmployee
            // 
            this.textEmployee.Location = new System.Drawing.Point(114, 154);
            this.textEmployee.Name = "textEmployee";
            this.textEmployee.Size = new System.Drawing.Size(100, 20);
            this.textEmployee.TabIndex = 8;
            // 
            // textBank
            // 
            this.textBank.Location = new System.Drawing.Point(114, 200);
            this.textBank.Name = "textBank";
            this.textBank.Size = new System.Drawing.Size(100, 20);
            this.textBank.TabIndex = 9;
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(84, 259);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(75, 23);
            this.INSERT.TabIndex = 10;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 201);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(256, 259);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 12;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(370, 258);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 13;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(479, 257);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 318);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.View);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.textBank);
            this.Controls.Add(this.textEmployee);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textAccount_no);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Account_no);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Account_no;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Label Bank;
        private System.Windows.Forms.TextBox textAccount_no;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.TextBox textEmployee;
        private System.Windows.Forms.TextBox textBank;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
    }
}

