using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace TernavskyLab5
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
        public int Rating { get; set; }

        public Product(string name, double price, string description, ProductCategory category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }
    }

}
