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
namespace Bank_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-65PH66KB\\SQLEXPRESS1;Initial Catalog=bank_db;Integrated Security=True");
        private void INSERT_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "insert into account(type,balance,branch_id,customer_id) values ('" + textType.Text + "','" + textBalance.Text + "','" + textBranch_id.Text + "','" + textCustomer_id.Text + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data insert successful");
        }

        private void View_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "select * from account";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textType.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBalance.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBranch_id.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textCustomer_id.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            con.Open();
            var account_no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string Query = "update account set type='" + textType.Text + "',balance='" + textBalance.Text + "',branch_id='" + textBranch_id.Text + "',customer_id='" + textCustomer_id.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data updated");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            var account_no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string Query = "delete from account where account_no = '" +textBranch_id.Text+ "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }
    }
}
