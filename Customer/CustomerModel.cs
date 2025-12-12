using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Customer
{
    internal class CustomerModel
    {
        public string name { get; set; }
        public string phonenumber {  get; set; }
        public int age {  get; set; }
        public string address {  get; set; }
        public int Id { get; set; }
        public CustomerModel(string name, string phonenumber, int age, string address)
        {
            this.name = name;
            this.phonenumber = phonenumber;
            this.age = age;
            this.address = address;
        }
        public CustomerModel(string name, string phonenumber, int age, string address, int Id)
        {
            this.name = name;
            this.phonenumber = phonenumber;
            this.age = age;
            this.address = address;
            this.Id = Id;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public void setphonenumber(string phonenumber)
        {
            this.phonenumber = phonenumber;
        }
        public string getphonenumber()
        {
            return this.phonenumber;
        }
        public void setage(int age)
        {
            this.age = age;
        }
        public int getage()
        {
            return this.age;
        }
        public void setaddress(string address)
        {
            this.address = address;
        }
        public string getaddress()
        {
            return this.address;
        }
        public override string ToString()
        {
            return $"{name},{phonenumber},{age},{address}";
        }

    }
}

