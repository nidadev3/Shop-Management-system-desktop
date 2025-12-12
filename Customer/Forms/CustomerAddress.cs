using _2nddesktopapp.Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nddesktopapp.Customer.Forms
{
    public partial class CustomerAddress : Form
    {
        public CustomerAddress()
        {
            InitializeComponent();
        }

        private void backcustomeraddress_Click(object sender, EventArgs e)
        {
            CustomerAdvanceFeature_Form customerAdvanceFeature_Form = new CustomerAdvanceFeature_Form();
            customerAdvanceFeature_Form.Show();
        }

        private void searchcustomrtaddress_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Customer WHERE Address = @Address;", con);

                sqlDa.SelectCommand.Parameters.AddWithValue("@Address", textBox1.Text);
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
