namespace Pen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Jel = new System.Windows.Forms.RadioButton();
            this.Ball = new System.Windows.Forms.RadioButton();
            this.point1 = new System.Windows.Forms.RadioButton();
            this.point2 = new System.Windows.Forms.RadioButton();
            this.point3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose the features of pen you want to add:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Point";
            // 
            // Jel
            // 
            this.Jel.AutoSize = true;
            this.Jel.Location = new System.Drawing.Point(179, 117);
            this.Jel.Name = "Jel";
            this.Jel.Size = new System.Drawing.Size(38, 17);
            this.Jel.TabIndex = 5;
            this.Jel.TabStop = true;
            this.Jel.Text = "Jel";
            this.Jel.UseVisualStyleBackColor = true;
            // 
            // Ball
            // 
            this.Ball.AutoSize = true;
            this.Ball.Location = new System.Drawing.Point(261, 117);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(42, 17);
            this.Ball.TabIndex = 6;
            this.Ball.TabStop = true;
            this.Ball.Text = "Ball";
            this.Ball.UseVisualStyleBackColor = true;
            // 
            // point1
            // 
            this.point1.AutoSize = true;
            this.point1.Location = new System.Drawing.Point(179, 170);
            this.point1.Name = "point1";
            this.point1.Size = new System.Drawing.Size(37, 17);
            this.point1.TabIndex = 8;
            this.point1.TabStop = true;
            this.point1.Text = "10";
            this.point1.UseVisualStyleBackColor = true;
            // 
            // point2
            // 
            this.point2.AutoSize = true;
            this.point2.Location = new System.Drawing.Point(222, 170);
            this.point2.Name = "point2";
            this.point2.Size = new System.Drawing.Size(37, 17);
            this.point2.TabIndex = 9;
            this.point2.TabStop = true;
            this.point2.Text = "15";
            this.point2.UseVisualStyleBackColor = true;
            // 
            // point3
            // 
            this.point3.AutoSize = true;
            this.point3.Location = new System.Drawing.Point(261, 170);
            this.point3.Name = "point3";
            this.point3.Size = new System.Drawing.Size(37, 17);
            this.point3.TabIndex = 10;
            this.point3.TabStop = true;
            this.point3.Text = "20";
            this.point3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(179, 144);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(119, 20);
            this.textColor.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(485, 321);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.point3);
            this.Controls.Add(this.point2);
            this.Controls.Add(this.point1);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Jel);
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
        private System.Windows.Forms.RadioButton Jel;
        private System.Windows.Forms.RadioButton Ball;
        private System.Windows.Forms.RadioButton point1;
        private System.Windows.Forms.RadioButton point2;
        private System.Windows.Forms.RadioButton point3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textColor;
    }
}

