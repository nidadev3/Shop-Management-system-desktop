using _2nddesktopapp.Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Order
{
    internal class OrderRepoDb
    {
        public bool Create(OrderModel Order)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "insert into orderitems (customername,contact,address,item) " +
                    "values (@customername,@contact,@address,@item)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@customername", Order.customername);
                command.Parameters.AddWithValue("@contact", Order.phonenumber);
                command.Parameters.AddWithValue("@address", Order.address);
                command.Parameters.AddWithValue("@item", Order.ListToString());
                command.Parameters.AddWithValue("@Id", Order.Id);

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
        public List<OrderModel> GetAllOrders()
        {
            List<OrderModel> orderlist = new List<OrderModel>();
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "select * from orderitems";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string customername = reader["customername"].ToString();
                    string contact = reader["contact"].ToString();
                    string address = reader["address"].ToString();
                    string allitems = reader["item"].ToString();
                    OrderModel order = new OrderModel(customername, contact, 0, address);
                    order.StringToList(allitems);
                    orderlist.Add(order);
                }
            }
            return orderlist;
        }

        public bool Delete(int Id)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "Delete from orderitems where Id=@Id";
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

        public OrderModel GetOrderbyName(string customername)
        {
            OrderModel Orders = null;

            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();

                string query = "Select Id, customername, contact, address From OrderItems WHERE customername = @customername";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@customername", customername);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    string name = reader["customername"].ToString();
                    string contact = reader["contact"].ToString();
                    string address = reader["address"].ToString();
                    string allitems = reader["item"].ToString();

                    OrderModel orders = new OrderModel(customername, contact, 0, address);
                    orders.StringToList(allitems);

                }

                reader.Close();
            }

            return Orders;
        }
        public bool Update(OrderModel order)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = @"UPDATE orderitems 
                         SET customername=@customername, 
                          contact=@contact, 
                          address=@address, 
                          item=@item  
                         WHERE Id=@Id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Id", order.Id);
                command.Parameters.AddWithValue("@customername", order.customername);
                command.Parameters.AddWithValue("@contact", order.phonenumber);
                command.Parameters.AddWithValue("@address", order.address);
                command.Parameters.AddWithValue("@item", order.ListToString());

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
    }
}
