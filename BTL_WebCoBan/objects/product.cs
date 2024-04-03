using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WebCoBan.objects
{
    public class product
    {
        private int id;
        private string name;
        private string description;
        private string img;
        private double price;
        private string brand;
        private int discount;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Img { get => img; set => img = value; }
        public double Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Discount { get => discount; set => discount = value; }

        public product() { }

        public product(int id, string name, string description, string img, double price, string brand, int discount)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.img = img;
            this.price = price;
            this.brand = brand;
            this.discount = discount;
        }

        
    }
}