using System;
using System.Collections.Generic;

namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Product_ID = 1, Name = "Laptop", Quantity = 3, Price = 12000.50m },
                new Product { Product_ID = 2, Name = "Mouse", Quantity = 25, Price = 250.00m },
                new Product { Product_ID = 3, Name = "Keyboard", Quantity = 13, Price = 750.25m }
            };

            // Using the extension method
            decimal totalPrice = products.CalculateTotalPrice();

            Console.WriteLine($"Total price of products: R {totalPrice}\n");

            int lowQuantity = 5;
            IEnumerable<Product> lowStockProducts = products.GetProductsByQuantity(lowQuantity);

            Console.WriteLine("Products that are low in stock:");
            foreach (var product in lowStockProducts)
            {
                Console.WriteLine($"- {product.Name} (Quantity: {product.Quantity})\n");
            }

            products.DisplayProductDetails();
        }
    }
}
