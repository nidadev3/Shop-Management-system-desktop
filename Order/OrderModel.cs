
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Order
{
    internal class OrderModel
    {
        public string customername;
        public string phonenumber;
        public int age;
        public string address;
        public int Id;
        public List<OrderItem> OrderList = new List<OrderItem>();


        public OrderModel(string customername, string phonenumber, int age, string address)
        {
            this.customername = customername;
            this.phonenumber = phonenumber;
            this.age = age;
            this.address = address;

        }
        public OrderModel(string customername, string phonenumber, string address, int Id)
        {
            this.customername = customername;
            this.phonenumber = phonenumber;

            this.address = address;
            this.Id = Id;
        }

        public string ListToString()
        {
            string data = "";
            foreach (OrderItem item in OrderList)
            {
                data += item.ToString() + "\n";
            }
            return data;
        }

        public void StringToList(string allitems)
        {
            string[] items = allitems.Split('\n');
            foreach (string item in items)
            {
                string[] parts = item.Split(',');
                if (parts.Length >= 3)
                {
                    string product = parts[0];
                    int quantity = int.Parse(parts[1]);
                    int saleprice = int.Parse(parts[2]);
                    OrderItem order = new OrderItem(product, quantity, saleprice);
                    OrderList.Add(order);
                }
            }
        }
        public void AddOrder(OrderItem item)
        {
            OrderList.Add(item);
        }
        public override string ToString()
        {
            return $"{customername}, {phonenumber}, {age}, {address}";
        }
    }
}
