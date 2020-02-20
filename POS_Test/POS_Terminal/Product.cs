using System;
using System.Collections.Generic;
using System.Text;

namespace POS_Terminal
{
    public class Product
    {
        private string name;
        private string category;
        private string description;
        private double price;

        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }

        public Product()
        {

        }
        public Product(string name, string category, string description, double price)
        {
            this.name = name;
            this.category = category;
            this.description = description;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{name}: {price}\n{category}: {description}";
        }
    }
}
