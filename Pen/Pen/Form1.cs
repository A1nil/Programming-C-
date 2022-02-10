using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Type;
            if (Jel.Checked)
            {
                Type = "Jel";
            }
            else
            {
                Type = "Ball";
            }

            string Color = textColor.Text;

            string Point;
            if (point1.Checked)
            {
                Point = "10";
            }
            else
            {
                Point = "20";
            }

            MessageBox.Show("Selection Confirmed");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
