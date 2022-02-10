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
namespace account.cs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-65PH66KB\\SQLEXPRESS1;Initial Catalog=window;Integrated Security=True");
        private void ADD_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("AddBalance", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@account", SqlDbType.BigInt).Value=textAccount1.Text;
            cmd.Parameters.Add("@amount", SqlDbType.BigInt).Value = textAmount.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Balance added");
            con.Close();
        }
    }
}
