using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Product
{
    internal class ProductService
    {
        private ProductRepoFh _repo = new ProductRepoFh();
        public ProductRepoDb _repoDB = new ProductRepoDb();

        public ProductService()
        {

        }

        public List<ProductModel> GetAllData()
        {
            return _repo.GetAllProductsFromFile();
        }

        public void SaveProduct(ProductModel product)
        {
            _repo.SaveInFile(product);
        }

        public List<ProductModel> SearchbyName(string name)
        {
            List<ProductModel> matchedProducts = new List<ProductModel>();
            foreach (ProductModel product in GetAllData())
            {
                if (product.getname() == name)
                {
                    matchedProducts.Add(product);
                }
            }
            return matchedProducts;
        }
        public List<ProductModel> SearchbyPrice(int saleprice)
        {
            List<ProductModel> matchedProducts = new List<ProductModel>();
            foreach (ProductModel product in GetAllData())
            {
                if (product.getsaleprice() == saleprice)
                {
                    matchedProducts.Add(product);
                }
            }
            return matchedProducts;
        }
        public List<ProductModel> SearchbyPriceRange(int minprice, int maxprice)
        {
            List<ProductModel> matchedProducts = new List<ProductModel>();
            foreach (ProductModel product in GetAllData())
            {
                double price = product.getsaleprice();
                if (price >= minprice && price <= maxprice)
                {
                    matchedProducts.Add(product);
                }
            }
            return matchedProducts;
        }
        public List<ProductModel> SearchbyPriceDiffer(int difference)
        {
            List<ProductModel> matchedProducts = new List<ProductModel>();
            foreach (ProductModel product in GetAllData())
            {
                double profit = product.getpurchaseprice() - product.getsaleprice();
                if (profit == difference)
                {
                    matchedProducts.Add(product);
                }
            }
            return matchedProducts;
        }
        public List<ProductModel> SearchbySubstring(string substring)
        {
            List<ProductModel> matchedProducts = new List<ProductModel>();

            foreach (ProductModel product in GetAllData())
            {

                if (product.getname().ToLower().Contains(substring.ToLower()))
                {
                    matchedProducts.Add(product);
                }
            }

            return matchedProducts;
        }
        //public List<ProductModel> SearchBySubstring(string substring)
        //{
        //    List<ProductModel> allProducts = _repo.GetAllProductsFromFile();
        //    List<ProductModel> matchedProducts = new List<ProductModel>();

        //    foreach (ProductModel product in allProducts)
        //    {

        //        if (product.getname().ToLower().Contains(substring.ToLower()))
        //        {
        //            matchedProducts.Add(product);
        //        }
        //    }

        //    return matchedProducts;
        //}


        public bool updateproductprice(string name, double price)
        {
            List<ProductModel> products = GetAllData();
            foreach (ProductModel product in products)
            {
                if (product.getname() == name)
                {
                    product.setsaleprice(price);
                    _repo.SaveAllDataInFile(products);
                    return true;
                }
            }
            return false;
        }
        public List<ProductModel> GetAll()
        {
            return _repoDB.GetAll();  // Calls your database repo GetAll()
        }

        public bool deleteproduct(string name)
        {
            List<ProductModel> products = _repo.GetAllProductsFromFile();



            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].getname() == name)
                {
                    products.RemoveAt(i);
                    _repo.SaveAllDataInFile(products);
                    return true;
                }
            }
            return false;
        }
    }
}
