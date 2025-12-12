using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Customer
{
    internal class CustomerRepoFH
    {
        private readonly string file = "Customers.txt";
        public CustomerRepoFH() { }
        public void SaveInFile(CustomerModel customer)

        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(customer.ToString());
            }
        }
        public void SaveAllDataInFile(List<CustomerModel> customerslist)
        {
            File.WriteAllText(file, "");
            foreach (CustomerModel customer in customerslist)
            {
                SaveInFile(customer);
            }
        }
        public List<CustomerModel> GetAllCustomersFromFile()
        {
            List<CustomerModel> customerslist = new List<CustomerModel>();


            if (!File.Exists(file))
            {
                return customerslist;
            }
            using (StreamReader stream = new StreamReader(file))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        string name = parts[0];
                        string phonenumber = parts[1];
                        int age = int.Parse(parts[2]);
                        string address = parts[3];
                        CustomerModel customer = new CustomerModel(name, phonenumber, age, address);
                        customerslist.Add(customer);
                    }
                }
            }
            return customerslist;
        }
    }
}
