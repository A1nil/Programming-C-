using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Payment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-65PH66KB\\SQLEXPRESS1;Initial Catalog=Electricity_Bill;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to reset your info?");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string City = textCity.Text;
            string Bill_no = textBill.Text;
            string Account_no = textAccount.Text;
            string Net_amount = textAmount.Text;
            string Contact_no = textContact.Text;
            string Month = textMonth.Text;

            MessageBox.Show("Confirm Payment?");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "select * from Bill";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textMonth.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textCity.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBill.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textAccount.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textAmount.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textContact.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
