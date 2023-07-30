using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] markalar = new string[] { "Mercedes Benz", "BMW", "Audi", "Fiat" };

            for (int i = 0; i < markalar.Length; i++)
            {
                Console.WriteLine(markalar[i]);
            }
            Console.WriteLine("Sayfa sonu");
            string[] kategoriler = new string[] { "A class", "B class", "Van", "coupe" };
            for (int i = 0; i < kategoriler.Length; i++)
            {
                Console.WriteLine(kategoriler[i]);
            }
            Console.WriteLine("/////////////////////");
            foreach (var marka in markalar)
            {
                Console.WriteLine(marka);
            }
            foreach (var kategori in kategoriler)
            {
                Console.WriteLine(kategori);
            }


            string[] laptoplar = new string[] { "asus", "apple", "lenovo" };
            for (int i = 0; i < laptoplar.Length; i++)
            {
                Console.WriteLine(laptoplar[i]);
            }
            Console.WriteLine("* DÖNGÜ BİTİ *");

            foreach (var laptop in laptoplar)
            {
                Console.WriteLine(laptop);
            }




            Console.ReadLine();
        }
    }
}

