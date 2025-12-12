using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Order
{
    internal class OrderItem
    {
        public string product;

        public int quantity;
        public int saleprice;
        public OrderItem(string product, int quantity, int saleprice)
        {
            this.product = product;

            this.quantity = quantity;
            this.saleprice = saleprice;
        }
        public override string ToString()
        {
            return $"{product}, {quantity}, {saleprice}";
        }
    }
}
