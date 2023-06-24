using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prod
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Xiaomi Redmi Note 11";
            product1.ProductPrice = 80000;
            product1.ProductMemory = "128GB";
            product1.productId = 12213;

            Product product2 = new Product();
            product2.ProductName = "İphone 12";
            product2.ProductPrice = 14000;
            product2.ProductMemory = "64GB";
            product2.productId = 129813;

            Product product3 = new Product();
            product3.ProductName = "İphone 11";
            product3.ProductPrice = 13000;
            product3.ProductMemory = "64GB";
            product3.productId = 12903;

            Product[] product = new Product[] {product1,product2,product3 };

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(product[i].ProductName);
            }

            foreach (var products in product)
            {
                Console.WriteLine(products.ProductPrice);
            }


            Console.ReadLine();
        }
    }
    class Product
    {
    public string ProductName { get; set; }
    public int ProductPrice { get; set; }
    public string ProductMemory { get; set; }
    public int productId { get; set; }
}
}
