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
               
                products =JsonSerializer.Deserialize<List<Product>>(jsonProducts);
            }
        }

        private int GetNextId()
        {
            return products[products.Count - 1].id + 1;
        }
        public void Create(Product p)
        {
            p.id = GetNextId();
            products.Add(p);
        }
        
        public void Edit(Product p)
        {
            var oldProduct= List().FirstOrDefault(x => x.id == p.id);
            oldProduct.name = p.name;
            oldProduct.price = p.price;
        }
        public void Delete(Product p)
        {   
            products.Remove(p);
           
        }
        public string Save()
        {
            return JsonSerializer.Serialize(products);  
        }

        public List<Product> List()
        {
            return products;
        }
    }
}
