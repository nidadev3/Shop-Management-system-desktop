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

namespace _2nddesktopapp.Product.Forms
{
    public partial class Productbyname : Form
    {
        public Productbyname()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Product WHERE name = @name;", con);

                sqlDa.SelectCommand.Parameters.AddWithValue("@name", textBox1.Text);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Backproductname_Click(object sender, EventArgs e)
        {
            AdvanceFeaturesProduct_Form advancefeature=new AdvanceFeaturesProduct_Form();
            advancefeature.Show();
        }
    }
}
