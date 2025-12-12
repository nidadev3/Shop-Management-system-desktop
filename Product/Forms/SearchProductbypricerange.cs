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

namespace _2nddesktopapp.Product.Forms
{
    public partial class SearchProductbypricerange : Form
    {
        public SearchProductbypricerange()
        {
            InitializeComponent();
        }

        private void enterpricerange_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backpricerange_Click(object sender, EventArgs e)
        {
            AdvanceFeaturesProduct_Form advancefeature = new AdvanceFeaturesProduct_Form();
            advancefeature.Show();
        }

        private void searchbypricerange_Click(object sender, EventArgs e)
        {
            int maxprice = Convert.ToInt32(textBox1.Text);
            int minprice = Convert.ToInt32(textBox2.Text);
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Product WHERE saleprice BETWEEN @minprice AND  @maxprice;", con);

                sqlDa.SelectCommand.Parameters.AddWithValue("@minprice", minprice);
                sqlDa.SelectCommand.Parameters.AddWithValue("@maxprice", maxprice);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
