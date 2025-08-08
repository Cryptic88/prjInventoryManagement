using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public class Product
    {
        //Custom types
        public int Product_ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
    public static class ProductExtensions
    {
        // Extension methods
        public static decimal CalculateTotalPrice(this List<Product> products)
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;
        }

        public static List<Product> GetProductsByQuantity(this List<Product> products, int lowQuantity)
        {
            
            return products.Where(p => p.Quantity <= lowQuantity).ToList();
        }
        public static void DisplayProductDetails(this List<Product> products)
        {
            var productInfo = from p in products
                              select new
                              {
                                  ProductName = p.Name,
                                  ProductPrice = p.Price
                              };

            Console.WriteLine("Product Details:\n");

            foreach (var item in productInfo)
            {
                Console.WriteLine($"Name: {item.ProductName}, Price: R {item.ProductPrice}");
            }
        }
    }

}
