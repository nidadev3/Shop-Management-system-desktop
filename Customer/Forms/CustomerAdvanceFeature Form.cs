using _2nddesktopapp.Customer.Forms;
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
    public partial class CustomerAdvanceFeature_Form : Form
    {
        public CustomerAdvanceFeature_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerName customerName = new CustomerName();
            customerName.Show();
        }

        private void cusbyaddress_Click(object sender, EventArgs e)
        {
            CustomerAddress customerAddress = new CustomerAddress();
            customerAddress.Show();
        }

        private void cusbyage_Click(object sender, EventArgs e)
        {
            CustomerAge customerAge = new CustomerAge();
            customerAge.Show();
        }

        private void cusbycontact_Click(object sender, EventArgs e)
        {
            CustomerContact customerContact = new CustomerContact();
            customerContact.Show();
        }

        private void cusbychar_Click(object sender, EventArgs e)
        {
            CustomerSubstring customerSubstring = new CustomerSubstring();
            customerSubstring.Show();
        }

        private void advancecusback_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
