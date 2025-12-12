using _2nddesktopapp.Product.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nddesktopapp.Product
{
    public partial class AdvanceFeaturesProduct_Form : Form
    {
        public AdvanceFeaturesProduct_Form()
        {
            InitializeComponent();
        }

        private void backpro_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void probyname_Click(object sender, EventArgs e)
        {
            Productbyname productbyname = new Productbyname();
            productbyname.Show();
        }

        private void probyprice_Click(object sender, EventArgs e)
        {
            ProductbyPrice productbyPrice = new ProductbyPrice();
            productbyPrice.Show();
        }

        private void probypricerange_Click(object sender, EventArgs e)
        {
            SearchProductbypricerange searchProductbypricerange = new SearchProductbypricerange();
            searchProductbypricerange.Show();
        }

        private void probypricediffer_Click(object sender, EventArgs e)
        {
            ProductbyPricedifference productbyPricedifference = new ProductbyPricedifference();
            productbyPricedifference.Show();
        }

        private void AdvanceFeaturesProduct_Form_Load(object sender, EventArgs e)
        {

        }

        private void probysubstring_Click(object sender, EventArgs e)
        {
            ProductbySubstring productbySubstring = new ProductbySubstring();
            productbySubstring.Show();
        }
    }
}
 