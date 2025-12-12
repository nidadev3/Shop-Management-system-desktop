using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Order
{
    internal class OrderService
    {
        private readonly OrderRepo _repo = new OrderRepo();
        public OrderService()
        {

        }
        public List<OrderModel> GetAllData()
        {
            return _repo.GetAllOrders();
        }

        public void SaveOrder(OrderModel order)
        {
            _repo.Savedata(order);
        }

        public List<OrderModel> Getorderbycustomer(string customername)
        {
            List<OrderModel> Allorders = _repo.GetAllOrders();
            List<OrderModel> CustomerOrder = new List<OrderModel>();
            foreach (OrderModel order in Allorders)
            {
                if (order.customername == customername)
                {
                    CustomerOrder.Add(order);
                }

            }

            return CustomerOrder;

        }
    }
}
