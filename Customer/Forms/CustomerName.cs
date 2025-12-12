using _2nddesktopapp.Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nddesktopapp.Customer.Forms
{
    public partial class CustomerName : Form
    {
        //string DBConnection = @"Data Source=LocalHost; Initial Catalog=POS; Integrated Security=True; TrustServerCertificate=True;";

        public CustomerName()
        {
            InitializeComponent();
        }

        private void backcustomername_Click(object sender, EventArgs e)
        {
            CustomerAdvanceFeature_Form customerAdvanceFeature_Form = new CustomerAdvanceFeature_Form();
            customerAdvanceFeature_Form.Show();
        }

        private void searchnamecustomer_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
               con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Customer WHERE Name = @Name;", con);

                sqlDa.SelectCommand.Parameters.AddWithValue("@Name", textBox1.Text);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
