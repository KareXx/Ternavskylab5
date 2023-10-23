using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernavskyLab5
{
    internal class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string OrderStatus { get; set; }

        public User User { get; set; }



        public Order(Product product, int quantity, User user)
        {
            Product = product;
            Quantity = quantity;
            User = user;
            OrderStatus = OrderStatus = "filling";

        }

        public double FullPrice
        {
            get
            {
                if (Product != null)
                {
                    return Quantity * Product.Price;
                }
                return 0;
            }
        }
    }
}
