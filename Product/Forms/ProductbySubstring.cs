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
    public partial class ProductbySubstring : Form
    {
        public ProductbySubstring()
        {
            InitializeComponent();
        }

        private void backproductsubstring_Click(object sender, EventArgs e)
        {
            AdvanceFeaturesProduct_Form advancefeature = new AdvanceFeaturesProduct_Form();
            advancefeature.Show();
        }

        private void searchproductsubstring_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(
                    "SELECT * FROM Product WHERE name LIKE '%' + @name + '%';", con);

                sqlDa.SelectCommand.Parameters.AddWithValue("@name", textBox1.Text);

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
