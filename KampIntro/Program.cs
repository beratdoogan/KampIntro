using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // string kategoriEtiketi = "Kategori";
            // Console.WriteLine(kategoriEtiketi);
            // int urunFiyat = 39;
            // Console.WriteLine("Ürün Fiyatı : " + urunFiyat);
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            

            int ogrenciSayisi = 9000;
            double faizOrani = 1.45;

            if (ogrenciSayisi < 10000)
            {
                Console.WriteLine("Öğrenci sayısı " + ogrenciSayisi + "." + " Öğrenci sayısı beklenenden az.");
            }
            else
            {
                Console.WriteLine("Öğrenci sayısı yeterli.");
            }

            bool systemOn = true;
            bool cacheOff = false;

            if (systemOn == true)
            {
                Console.WriteLine("Ayarlarım");
            }

            double dolarDun = 7.95;
            double dolarBugun = 7.45;

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar düne göre artmış");
            }
            else if (dolarBugun == dolarDun)
            {
                Console.WriteLine("Dolar değişmemiş");
            }
            else
            {
                Console.WriteLine("Dolar düne göre azalmış");
            }






            Console.ReadLine();
        }
    }
}
