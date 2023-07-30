using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager // crud operasyonları
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " adlı ürün sisteme eklendi");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName +  " adlı ürün sistemden kaldırıldı");
        }
        public void Update(Product product) // encapsulation
        {
            Console.WriteLine( product.ProductName + " adlı ürün sistemden güncellendi");
        }
        public void Reload (Product product)
        {
            Console.WriteLine(product.ProductName + " adlı ürün okundu");
        }
    }
}
