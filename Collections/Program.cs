using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> sehirler = new List<string> { "Mersin", "Ankara", "Konya" };
            //sehirler.Add("İstanbul");


            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}


            List<string> brands = new List<string> { "BMW" };
            brands.Add("Audi");
            Console.WriteLine(brands[0]);
            Console.WriteLine(brands[1]);



            Console.ReadLine();
        }
    }
}
