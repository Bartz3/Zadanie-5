using System;
using System.Collections.Generic;
//using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Zadanie_5.Models;
namespace Zadanie_5.DAL
{
    public class ProductDB
    {
        private List<Product> products;

        public void Load(string jsonProducts)
        {
            if(jsonProducts== null)
            {
                products=Product.GetProducts();
            }
            else
            {
                products=JsonSerializer.Deserialize<List<Product>>(jsonProducts);
            }
        }

        private int GetNextId()
        {
            int lastID = products[products.Count - 1].id;
            int newId = lastID++;
            return newId;
        }
        public void Create(Product p)
        {
            p.id = GetNextId();
            products.Add(p);
        }
    }
}
