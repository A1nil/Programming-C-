using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace successful
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DOWNLOAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Download Successfull");
        }

        private void COPY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copied Successfully");
        }
    }
}
