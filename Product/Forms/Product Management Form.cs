using _2nddesktopapp.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2nddesktopapp.Product
{
    public partial class Product_Management_Form : Form
    {
        ProductRepoDb repo = new ProductRepoDb();
        public Product_Management_Form()
        {
            InitializeComponent();
        }

        private void lblSalePro_Click(object sender, EventArgs e)
        {

        }

        private void lblDisPro_Click(object sender, EventArgs e)
        {

        }

        private void ProId_Click(object sender, EventArgs e)
        {

        }

        private void lblProDes_Click(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void lblProductPrice_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPro_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int purchaseprice = int.Parse(textBox3.Text);
            int saleprice = int.Parse(textBox4.Text);
            int discount = int.Parse(textBox7.Text);
            ProductModel product = new ProductModel(name, purchaseprice, saleprice, discount);
            repo.Create(product);
            var products = repo.GetAll();
            dataGridView1.DataSource = products;
        }

        private void updatepro_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox5.Text);
            string name = textBox1.Text;
            int purchaseprice = int.Parse(textBox3.Text);
            int saleprice = int.Parse(textBox4.Text);
            int discount = int.Parse(textBox7.Text);



            ProductModel product = new ProductModel(name, purchaseprice, saleprice, discount);

            product.Id = id;


            bool result = repo.Update(product);

            if (result)
            {
                MessageBox.Show("Product updated successfully!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void backpro_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void ViewPro_Click(object sender, EventArgs e)
        {
            var allproducts = repo.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allproducts;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletePro_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox5.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            bool result = repo.Delete(id);

            if (result)
            {
                MessageBox.Show("Product Deleted Successfully!");
                dataGridView1.DataSource = repo.GetAll();
            }
            else
            {
                MessageBox.Show("Delete Failed! ID may not exist.");
            }
        }
    }
}
