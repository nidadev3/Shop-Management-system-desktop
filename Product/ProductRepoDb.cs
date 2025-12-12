using _2nddesktopapp.Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Product
{
    internal class ProductRepoDb
    {
        public bool Create(ProductModel product)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "insert into Product (name,purchaseprice,saleprice,discount) " +
                    "values (@name,@purchaseprice,@saleprice,@discount)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@name", product.getname());
                command.Parameters.AddWithValue("@purchaseprice", product.getpurchaseprice());
                command.Parameters.AddWithValue("@saleprice", product.getsaleprice());
                command.Parameters.AddWithValue("@discount", product.getdiscount());
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
                string query = "Delete from Product where Id=@Id";
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


        public bool Update(ProductModel product)
        {
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "UPDATE Product SET name=@name , purchaseprice=@purchaseprice," +
                    " saleprice=@saleprice,discount=@discount  WHERE Id=@Id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Id", product.Id);
                command.Parameters.AddWithValue("@name", product.getname());
                command.Parameters.AddWithValue("@purchaseprice", product.getpurchaseprice());
                command.Parameters.AddWithValue("@saleprice", product.getsaleprice());
                command.Parameters.AddWithValue("@discount", product.getdiscount());
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

        public ProductModel GetProductbyName(string name)
        {
            ProductModel product = null;
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "Select Id,name,purchaseprice,saleprice,discount From Product WHERE name=@name";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@name", name);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    string names = Convert.ToString(reader["name"]);
                    double purchaseprices = Convert.ToDouble(reader["purchaseprice"]);
                    double saleprice = Convert.ToDouble(reader["saleprice"]);
                    double discount = Convert.ToDouble(reader["discount"]);
                    product = new ProductModel(names, purchaseprices, saleprice, discount, Id);
                }
                reader.Close();
            }
            return product;
        }
        public List<ProductModel> GetAll()
        {
            List<ProductModel> allproducts = new List<ProductModel>();
            using (SqlConnection con = new SqlConnection(Util.GetDbConnection()))
            {
                con.Open();
                string query = "select * from Product";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    string names = Convert.ToString(reader["name"]);
                    double purchaseprices = Convert.ToDouble(reader["purchaseprice"]);
                    double saleprice = Convert.ToDouble(reader["saleprice"]);
                    double discount = Convert.ToDouble(reader["discount"]);
                    ProductModel products = new ProductModel(names, purchaseprices, saleprice, discount, Id);
                    allproducts.Add(products);
                }
            }
            return allproducts;
        }

    }
}
