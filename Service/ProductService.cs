using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Service
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            using (StreamReader r = new StreamReader("C:/Daniela/React/products.json"))
            {
                string json = r.ReadToEnd();
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

                return products;
            }
        }

        public Product GetProduct(int id)
        {
            using (StreamReader r = new StreamReader("C:/Daniela/React/products.json"))
            {
                string json = r.ReadToEnd();
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

                return products.Find(x => x.Id == id);
            }
        }
    }
}
