using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitInStock = 10;
            product1.UnitPrice = 500;

            Product product2 = new Product() { Id = 2, ProductName = "Kalem", 
            CategoryId = 4, UnitPrice = 20, UnitInStock = 20 } ;

            Product product3 = new Product();
            product3.ProductName = "Sandalye";
            product3.CategoryId = 2;
            product3.Id = 3;
            product3.UnitInStock = 10;
            product3.UnitPrice = 100;


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Reload(product2);
            productManager.Delete(product3);


            Console.ReadLine(); 

        }
    }
}
