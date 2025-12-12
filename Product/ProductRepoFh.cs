using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nddesktopapp.Product
{
    internal class ProductRepoFh
    {
        private readonly string file = "products.txt";

        public ProductRepoFh() { }

        public void SaveInFile(ProductModel product)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(product.ToString());
            }
        }

        public void SaveAllDataInFile(List<ProductModel> products)
        {
            File.WriteAllText(file, "");

            foreach (ProductModel product in products)
            {
                SaveInFile(product);
            }
        }

        public List<ProductModel> GetAllProductsFromFile()
        {
            List<ProductModel> products = new List<ProductModel>();


            if (!File.Exists(file))
            {
                return products;
            }

            using (StreamReader stream = new StreamReader(file))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    if (line.Length >= 5)
                    {

                        string[] parts = line.Split(',');

                        try
                        {
                            int Id = int.Parse(parts[0]);
                            string productName = parts[1];
                            string description = parts[2];
                            double purchaseprice = double.Parse(parts[3]);
                            double saleprice = double.Parse(parts[4]);
                            float discount = float.Parse(parts[5]);

                            ProductModel product = new ProductModel(Id, productName, description, purchaseprice, saleprice, discount);
                            products.Add(product);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine($"Skipping line due to format error: {line}");
                            // Optionally log ex.Message if you want to see the exact exception
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine($"Skipping line due to missing fields: {line}");
                        }
                    }

                }

            }
            Console.WriteLine("Total products are " + products.Count);
            return products;

        }
    }
}






