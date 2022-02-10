namespace Bank_db
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
            this.Type = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.Branch_id = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.Label();
            this.INSERT = new System.Windows.Forms.Button();
            this.textType = new System.Windows.Forms.TextBox();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.textBranch_id = new System.Windows.Forms.TextBox();
            this.textCustomer_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(39, 30);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 0;
            this.Type.Text = "Type";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(40, 79);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(46, 13);
            this.Balance.TabIndex = 1;
            this.Balance.Text = "Balance";
            // 
            // Branch_id
            // 
            this.Branch_id.AutoSize = true;
            this.Branch_id.Location = new System.Drawing.Point(40, 124);
            this.Branch_id.Name = "Branch_id";
            this.Branch_id.Size = new System.Drawing.Size(55, 13);
            this.Branch_id.TabIndex = 2;
            this.Branch_id.Text = "Branch_id";
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.Location = new System.Drawing.Point(40, 169);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(65, 13);
            this.customer_id.TabIndex = 3;
            this.customer_id.Text = "Customer_id";
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(93, 234);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(75, 23);
            this.INSERT.TabIndex = 4;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(107, 27);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(100, 20);
            this.textType.TabIndex = 5;
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(107, 74);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(100, 20);
            this.textBalance.TabIndex = 6;
            // 
            // textBranch_id
            // 
            this.textBranch_id.Location = new System.Drawing.Point(107, 119);
            this.textBranch_id.Name = "textBranch_id";
            this.textBranch_id.Size = new System.Drawing.Size(100, 20);
            this.textBranch_id.TabIndex = 7;
            // 
            // textCustomer_id
            // 
            this.textCustomer_id.Location = new System.Drawing.Point(107, 168);
            this.textCustomer_id.Name = "textCustomer_id";
            this.textCustomer_id.Size = new System.Drawing.Size(100, 20);
            this.textCustomer_id.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(457, 186);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(234, 234);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 10;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(346, 234);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(464, 234);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 289);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.View);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.textCustomer_id);
            this.Controls.Add(this.textBranch_id);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.Branch_id);
            this.Controls.Add(this.Balance);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label Branch_id;
        private System.Windows.Forms.Label customer_id;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.TextBox textBranch_id;
        private System.Windows.Forms.TextBox textCustomer_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
    }
}

