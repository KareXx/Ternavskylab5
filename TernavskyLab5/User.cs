using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernavskyLab5
{
    internal class User : ISearchable
    {
        public string Login { get; set; }
        public string Password { get; set; }
        private List<Order> purchaseHistory = new List<Order>();
        private Shop CurrentShop { get; set; }

        public User(string login, string password, Shop currentShop)
        {
            Login = login;
            Password = password;
            CurrentShop = currentShop;
        }

        public List<Product> SearchByPrice()
        {
            return CurrentShop.SearchByPrice();
        }

        public List<Product> SearchByCategory(string categoryName)
        {
           return CurrentShop.SearchByCategory(categoryName);
        }

        public List<Product> SearchByRating()
        {
            return CurrentShop.SearchByRating();
        }

        public void AddToPurchaseHistory(Order order)
        {
            purchaseHistory.Add(order);
        }

        public List<Order> PurchaseHistory
        {
            get { return purchaseHistory; }
        }

    }
}
