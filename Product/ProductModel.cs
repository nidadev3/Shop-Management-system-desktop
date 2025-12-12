using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Product
{
    internal class ProductModel
    {
       public  string name { get; set; }
     public  string description { get; set; }
        public double purchaseprice { get; set; }
        public  double saleprice { get; set; }
        public  double discount { get; set; }
        public int Id { get; set; }

        public ProductModel(int Id, string name, string description, double purchaseprice, double saleprice, float discount)
        {
            this.Id = Id;
            this.name = name;
            this.description = description;
            this.purchaseprice = purchaseprice;
            this.saleprice = saleprice;
            this.discount = discount;
        }
        public ProductModel(string name, double purchaseprice, double saleprice, double discount, int id)
        {
            this.name = name;
            this.purchaseprice = purchaseprice;
            this.saleprice = saleprice;
            this.discount = discount;
            this.Id = id;
        }
        public ProductModel(string name, double purchaseprice, double saleprice, double discount)
        {
            this.name = name;
            this.purchaseprice = purchaseprice;
            this.saleprice = saleprice;
            this.discount = discount;

        }

        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public string getDescription()
        {
            return this.description;
        }
        public void setpurchaseprice(double purchaseprice)
        {
            this.purchaseprice = purchaseprice;
        }
        public double getpurchaseprice()
        {
            return this.purchaseprice;

        }
        public void setsaleprice(double saleprice)
        {
            this.saleprice = saleprice;
        }
        public double getsaleprice()
        {
            return this.saleprice - discount;
        }
        public double getdiscount()
        {
            return this.discount;
        }
        public override string ToString()
        {
            return $"{name},{description},{purchaseprice},{saleprice},{discount}";
        }

    }
}
