using _2nddesktopapp.Customer;
using _2nddesktopapp.Order;
using _2nddesktopapp.Product;

namespace _2nddesktopapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.Show();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            Product_Management_Form form = new Product_Management_Form();
            form.Show();
        }

        private void btnCustomerAF_Click(object sender, EventArgs e)
        {
            CustomerAdvanceFeature_Form form = new CustomerAdvanceFeature_Form();
            form.Show();

        }

        private void btnProductAF_Click(object sender, EventArgs e)
        {
            AdvanceFeaturesProduct_Form advanceFeaturesProduct_Form = new AdvanceFeaturesProduct_Form();
            advanceFeaturesProduct_Form.Show();
        }
    }
}
