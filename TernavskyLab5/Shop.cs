using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernavskyLab5
{
    internal class Shop : ISearchable
    {
        private List<Product> products;

        public Shop(List<Product> products)
        {
            this.products = products;
        }

        public List<Product> SearchByPrice()
        {
            List<Product> sortedProducts = products.OrderBy(product => product.Price).ToList();
            return sortedProducts;
        }

        public List<Product> SearchByCategory(string categoryName)
        {
            var result = products.Where(product => product.Category.Name == categoryName).ToList();
            return result;
        }



        public List<Product> SearchByRating()
        {
            List<Product> sortedProducts = products.OrderByDescending(product => product.Rating).ToList();
            return sortedProducts;
        }
    }
}
