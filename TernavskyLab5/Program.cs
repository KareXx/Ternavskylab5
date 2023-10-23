using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernavskyLab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створюємо товари, категорії та магазин
            var category1 = new ProductCategory("Electronics");
            var category2 = new ProductCategory("Clothing");
            var product1 = new Product("Laptop", 1000.00, "Powerful laptop", category1);
            var product2 = new Product("T-shirt", 20.00, "Cotton T-shirt", category2);
            var product3 = new Product("Smartphone", 500.00, "Latest smartphone", category1);
            var shop = new Shop(new List<Product> { product1, product2, product3 });

            // Створюємо користувача та встановлюємо поточний магазин
            var user = new User("user123", "password123", shop);

            // Додаємо товари в замовлення користувача
            var order1 = new Order(product1, 2, user);
            var order2 = new Order(product2, 3, user);
            user.AddToPurchaseHistory(order1);
            user.AddToPurchaseHistory(order2);

            // Вивід інформації про замовлення користувачів
            Console.WriteLine("User's Purchase History:");
            foreach (var order in user.PurchaseHistory)
            {
                Console.WriteLine($"Product: {order.Product.Name}, Quantity: {order.Quantity}, Total Price: {order.FullPrice}");
            }

            // Пошук продукції за категорією
            string categoryNameToSearch = "Electronics";
            List<Product> productsInCategory = user.SearchByCategory(categoryNameToSearch);
            Console.WriteLine($"Products in the category '{categoryNameToSearch}':");
            foreach (var product in productsInCategory)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }

            // Пошук продукції за ціною
            List<Product> productsByPrice = user.SearchByPrice();
            Console.WriteLine("Products sorted by price:");
            foreach (var product in productsByPrice)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }

            // Пошук продукції за рейтингом
            List<Product> productsByRating = user.SearchByRating();
            Console.WriteLine("Products sorted by rating:");
            foreach (var product in productsByRating)
            {
                Console.WriteLine($"Name: {product.Name}, Rating: {product.Rating}");
            }

            Console.ReadLine();
        }
    }
}
