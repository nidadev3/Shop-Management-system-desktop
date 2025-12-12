using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Customer
{
    internal class CustomerService
    {
        private CustomerRepoFH _repo = new CustomerRepoFH();
        private CustomerRepoDB _repoDB = new CustomerRepoDB();
        public CustomerService()
        {
        }
        public List<CustomerModel> GetAllData()
        {
            return _repoDB.GetAll();
            //return _repo.GetAllCustomersFromFile();
        }
        public void SaveCustomer(CustomerModel customer)
        {
            _repoDB.Create(customer);
            //_repo.SaveInFile(customer);
        }
        public List<CustomerModel> SearchbyName(string name)
        {
            List<CustomerModel> result = new List<CustomerModel>();
            foreach (CustomerModel customer in _repo.GetAllCustomersFromFile())
            {
                if (customer.getname() == name)
                {
                    result.Add(customer);
                }

            }
            return result;
        }
        public List<CustomerModel> SearchbyAge(int age)
        {
            List<CustomerModel> result = new List<CustomerModel>();
            foreach (CustomerModel customer in _repo.GetAllCustomersFromFile())
            {
                if (customer.getage() == age)
                {
                    result.Add(customer);
                }
            }
            return result;
        }
        public List<CustomerModel> SearchbyPhonenumber(string phonenumber)
        {
            List<CustomerModel> result = new List<CustomerModel>();
            foreach (CustomerModel customer in _repo.GetAllCustomersFromFile())
            {
                if (customer.getphonenumber() == phonenumber)
                {
                    result.Add(customer);
                }
            }
            return result;
        }

        public List<CustomerModel> SearchbyAddress(string address)
        {
            List<CustomerModel> result = new List<CustomerModel>();
            foreach (CustomerModel customer in _repo.GetAllCustomersFromFile())
            {
                if (customer.getaddress() == address)
                {
                    result.Add(customer);
                }
            }
            return result;
        }

        public List<CustomerModel> SearchbyFirstChar(char firstchar)
        {
            List<CustomerModel> result = new List<CustomerModel>();
            foreach (CustomerModel customer in _repo.GetAllCustomersFromFile())
            {
                if (customer.getname()[0] == firstchar)
                {
                    result.Add(customer);
                }
            }
            return result;
        }
        public bool UpdateCustomer(string name, string phonenumber, int age, string address)
        {
            List<CustomerModel> customerslist = _repo.GetAllCustomersFromFile();
            foreach (CustomerModel customer in customerslist)
            {
                if (customer.getname() == name)
                {
                    customer.setname(name);
                    customer.setphonenumber(phonenumber);
                    customer.setaddress(address);
                    customer.setage(age);
                    _repo.SaveAllDataInFile(customerslist);
                    return true;
                }
            }
            return false;
        }
        public bool DeleteCustomer(string name)
        {
            List<CustomerModel> customerslist = _repo.GetAllCustomersFromFile();
            //int count = 0;


            for (int i = 0; i < customerslist.Count; i++)
            {
                if (customerslist[i].getname() == name)
                {
                    customerslist.RemoveAt(i);
                    _repo.SaveAllDataInFile(customerslist);
                    return true;
                }
            }
            return false;
        }
    }
}
