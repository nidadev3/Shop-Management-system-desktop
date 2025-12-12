using _2nddesktopapp.Product;
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

namespace _2nddesktopapp.Order
{
    public partial class OrderForm : Form
    {
        private ProductService service;
        public OrderForm()
        {
            InitializeComponent();
            service = new ProductService();
            LoadProducts();

        }
        private void ProductTable_Click(object sender, EventArgs e)
        {
            TableToField();
        }
        private void TableToField()
        {
            int index = ProductTable.CurrentCell.RowIndex;
            if (index >= 0)
            {
                string id = ProductTable.Rows[index].Cells[0].Value.ToString();
                string name = ProductTable.Rows[index].Cells[1].Value.ToString();
                string price = ProductTable.Rows[index].Cells[2].Value.ToString();
                textBox7.Text = id;
                textBox1.Text = name;
                textBox2.Text = price;
                CalculateTotal();
            }
        }
        private void LoadProducts()
        {
            List<ProductModel> products = service.GetAll();
            // ProductTable.DataSource = products;
            foreach (ProductModel product in products)
            {
                ProductTable.Rows.Add(product.Id, product.name, product.saleprice);

            }
        }

        private void lblorder_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            string price = textBox2.Text;
            string items = textBox3.Text;
            textBox3.ForeColor = Color.Black;
            string discount = textBox4.Text;

            try
            {
                float fprice = float.Parse(price);
                int iitems = int.Parse(items);

                float fdiscount = 0;
                if (discount.Length > 0)
                {
                    fdiscount = float.Parse(discount);
                }

               // float total = fprice * iitems;
                float finalTotal = fprice*iitems - fdiscount;
                textBox6.Text = finalTotal.ToString();
            }
            catch (Exception ex)
            {
                textBox6.Text = "0";
                textBox3.ForeColor = Color.Red;
            }
        }
        private void AddBillItemTable()
        {
            string product = textBox1.Text;
            string price = textBox2.Text;
            string items = textBox3.Text;
            string discount = textBox4.Text;
            string id = textBox7.Text;
            string total = textBox6.Text;
            dataGridView2.Rows.Add(id, product, price, items, discount, total);
            CalculateGrandTotal();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void additembtn_Click(object sender, EventArgs e)
        {
            AddBillItemTable();
            textBox3.Text = "0";
            textBox4.Text = "0";
            dataGridView2.Focus();
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddBillItemTable();
                textBox3.Text = "0";
                textBox4.Text = "0";
                dataGridView2.Focus();
            }
        }

        private void ProductTable_KeyUp(object sender, KeyEventArgs e)
        {
            TableToField();
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void ProductTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
            return;
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            TableToField();
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }
        private void CalculateGrandTotal()
        {
            float grandTotal = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    float value;
                    if (float.TryParse(row.Cells[5].Value.ToString(), out value))
                    {
                        grandTotal += value;
                    }
                }
            }

            textBox5.Text = grandTotal.ToString();
        }


    }
}

