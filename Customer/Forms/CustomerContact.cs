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
    public partial class CustomerContact : Form
    {
        public CustomerContact()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backcustomercontact_Click(object sender, EventArgs e)
        {
            CustomerAdvanceFeature_Form customerAdvanceFeature_Form = new CustomerAdvanceFeature_Form();
            customerAdvanceFeature_Form.Show();
        }

        private void searchcustomebycontack_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Customer WHERE PhoneNumber = @PhoneNumber;", con);

                    sqlDa.SelectCommand.Parameters.AddWithValue("@PhoneNumber", textBox1.Text);
                    DataTable dt = new DataTable();
                    sqlDa.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
