﻿using System;
using Newtonsoft.Json;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Product { ID = 101, Name = "Product-101", Price = 99.99 };
            var jsonString = Serialize(p1); // you can paste JSON string generated by JavaScript application
            System.Console.WriteLine(jsonString);
            var p2 = Deserialize(jsonString);
            System.Console.WriteLine($"{p2.ID}\t{p2.Name}\t{p2.Price}");
        }

        static string Serialize(Product product)
        {
            var jsonString = JsonConvert.SerializeObject(product);
            return jsonString;
        }

        static Product Deserialize(string jsonString)
        {
            var product = JsonConvert.DeserializeObject<Product>(jsonString);
            return product;
        }
    }

    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
