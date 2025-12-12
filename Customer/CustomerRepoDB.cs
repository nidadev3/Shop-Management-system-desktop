using _2nddesktopapp.Common;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Customer
{
    internal class CustomerRepoDB
    {
        public bool Create(CustomerModel customer)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "insert into Customer (Name,PhoneNumber,Age,Address) " +
                    "values (@Name,@PhoneNumber,@Age,@Address)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Name", customer.getname());
                command.Parameters.AddWithValue("@PhoneNumber", customer.getphonenumber());
                command.Parameters.AddWithValue("@Age", customer.getage());
                command.Parameters.AddWithValue("@Address", customer.getaddress());
                int effectrows = command.ExecuteNonQuery();
                if (effectrows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Delete(int Id)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "Delete from Customer where Id=@Id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Id", Id);

                int effectrows = command.ExecuteNonQuery();
                if (effectrows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public bool Update(CustomerModel customer)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "UPDATE Customer SET Name=@Name , PhoneNumber=@PhoneNumber," +
                    " Age=@Age,Address=@Address  WHERE Id=@Id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Id", customer.Id);
                command.Parameters.AddWithValue("@Name", customer.getname());
                command.Parameters.AddWithValue("@PhoneNumber", customer.getphonenumber());
                command.Parameters.AddWithValue("@Age", customer.getage());
                command.Parameters.AddWithValue("@Address", customer.getaddress());
                int effectrows = command.ExecuteNonQuery();
                if (effectrows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public CustomerModel GetCustomerbyName(string name)
        {
            CustomerModel customer = null;
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "Select Id,Name,PhoneNumber,Age,Address From Customer WHERE Name=@Name";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Name", name);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    string Name = Convert.ToString(reader["Name"]);
                    string PhoneNumber = reader["PhoneNumber"].ToString();
                    int Age = Convert.ToInt32(reader["Age"]);
                    string Address = Convert.ToString(reader["Address"]);
                    customer = new CustomerModel(Name, PhoneNumber, Age, Address, Id);
                }
                reader.Close();
            }
            return customer;
        }



        public List<CustomerModel> GetAll()
        {
            List<CustomerModel> allcustomer = new List<CustomerModel>();
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "select * from Customer";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    string name = reader["Name"].ToString();
                    string phonenumber = reader["PhoneNumber"].ToString();
                    int age = (int)reader["Age"];
                    string address = reader["Address"].ToString();
                    int id = (int)reader["Id"];
                    CustomerModel customers = new CustomerModel(name, phonenumber, age, address, id);
                    allcustomer.Add(customers);
                }
            }
            return allcustomer;
        }

    }
}
