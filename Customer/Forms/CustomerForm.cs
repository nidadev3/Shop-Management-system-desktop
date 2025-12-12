using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nddesktopapp.Customer
{
    public partial class CustomerForm : Form
    {
        CustomerRepoDB repo = new CustomerRepoDB();
       // string DBconnection = @"Data Source=LocalHost; Initial Catalog=POS; Integrated Security=True; TrustServerCertificate=True;";


        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CusName_Click(object sender, EventArgs e)
        {

        }

        private void CusContact_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        
        {
            var allCustomers = repo.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allCustomers;
        }

        

        private void btnbackCus_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string ContactName = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            string address = textBox4.Text;
            CustomerModel customer = new CustomerModel(Name, ContactName, age, address);
            repo.Create(customer);
            var customers = repo.GetAll();
            dataGridView1.DataSource = customers;
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnDelCus_Click(object sender, EventArgs e)
        //{
        //    int Id = int.Parse(textBox5.Text);
        //    bool result = repo.Delete(Id);
        //    if (result == true)
        //    {
        //        MessageBox.Show("Customer Deleted Successfully!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Delete Failed!");
        //    }

        //    //int id = Convert.ToInt32(textBox5.Text);
        //    //repo.Delete(id);
        //}

        //private void btnDelCus_Click_1(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(textBox5.Text);
        //    repo.Delete(id);
        //}

        private void btnDelCus_Click_2(object sender, EventArgs e)


        {
            if (!int.TryParse(textBox5.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            bool result = repo.Delete(id);

            if (result)
            {
                MessageBox.Show("Customer Deleted Successfully!");
                dataGridView1.DataSource = repo.GetAll();
            }
            else
            {
                MessageBox.Show("Delete Failed! ID may not exist.");
            }
        }

        private void btnUpdCus_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox5.Text);
            string name = textBox1.Text;
            string phone = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            string address = textBox4.Text;

            
            CustomerModel customer = new CustomerModel(name, phone, age, address);

            customer.Id = id;

          
            bool result = repo.Update(customer);

            if (result)
            {
                MessageBox.Show("Customer updated successfully!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }
    }



}
