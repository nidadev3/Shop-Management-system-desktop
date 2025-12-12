using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Order
{
    internal class OrderRepo
    {
        private readonly string _file = "Order.txt";
        public void Savedata(OrderModel order)
        {
            using (StreamWriter writer = new StreamWriter(_file, true))
            {
                string CustomerData = $"customer,{order.customername},{order.phonenumber},{order.age},{order.address}";
                writer.WriteLine(CustomerData);
                foreach (OrderItem items in order.OrderList)
                {
                    string line = $"item,{items.product},{items.quantity},{items.saleprice}";
                }

            }
        }

        public List<OrderModel> GetAllOrders()
        {
            List<OrderModel> orderlist = new List<OrderModel>();
            using (StreamReader reader = new StreamReader(_file))
            {
                string line = "";
                OrderModel temporder = null;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("customer"))
                    {
                        string[] parts = line.Split(',');


                        string customername = parts[1];
                        string phonenumber = parts[2];
                        int age = int.Parse(parts[3]);
                        string address = parts[4];
                        temporder = new OrderModel(customername, phonenumber, age, address);
                        orderlist.Add(temporder);

                    }
                    else if (line.StartsWith("item"))
                    {
                        string[] parts = line.Split(',');

                        string product = parts[1];
                        int quantity = int.Parse(parts[2]);
                        int saleprice = int.Parse(parts[3]);
                        OrderItem obj = new OrderItem(product, quantity, saleprice);
                        temporder.AddOrder(obj);


                    }
                }
            }
            return orderlist;
        }
    }
}
