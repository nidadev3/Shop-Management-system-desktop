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
    public partial class ProductbyPricedifference : Form
    {
        public ProductbyPricedifference()
        {
            InitializeComponent();
        }

        private void backpricedifference_Click(object sender, EventArgs e)
        {
            AdvanceFeaturesProduct_Form advancefeature = new AdvanceFeaturesProduct_Form();
            advancefeature.Show();
        }

        private void searchproductbypricedifference_Click(object sender, EventArgs e)
        {
            int maxprice = Convert.ToInt32(textBox1.Text);
            int minprice = Convert.ToInt32(textBox2.Text);
            int difference = maxprice - minprice;
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Product WHERE saleprice > @difference;", con);

                sqlDa.SelectCommand.Parameters.AddWithValue("@difference", difference);

                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        }
    }
    

