using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Python Dersleri";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 200000;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java Dersleri";
            kurs2.Egitmen = "Berat Doğan";
            kurs2.IzlenmeOrani = 450000;

            Arabalar araba1 = new Arabalar();
            araba1.marka = "Mercedes Benz S350";
            araba1.model = "2018";
            araba1.fiyat = 1200000;

            Arabalar araba3 = new Arabalar();
            araba3.marka = "Audi A4";
            araba3.model = "2019";
            araba3.fiyat = 1200000;

            Arabalar araba4 = new Arabalar();
            araba4.marka = "BMW 520d";
            araba4.model = "2020";
            araba4.fiyat = 890000;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            Arabalar[] araba = new Arabalar[] { araba1, araba3, araba4 };

            foreach (var arabax in araba)
            {
                Console.WriteLine(arabax.marka);
            }
            foreach (var arabaxs in araba)
            {
                Console.WriteLine(arabaxs.fiyat);
            }

            Laptop laptop1 = new Laptop();
            laptop1.laptopBrand = "Asus ";
            laptop1.laptopMemory = "512GB";
            laptop1.laptopPrice = 120000;

            Laptop laptop2 = new Laptop();
            laptop2.laptopBrand = "Apple";
            laptop2.laptopMemory = "512GB";
            laptop2.laptopPrice = 20000;

            Laptop[] laptoplar = new Laptop[] { laptop1, laptop2 };
            for (int i = 0; i < laptoplar.Length; i++)
            {
                Console.WriteLine(laptoplar[i].laptopBrand);
            }
            Console.WriteLine("stop");
            foreach (var laptop in laptoplar)
            {
                Console.WriteLine(laptop.laptopPrice);
            }

            Console.WriteLine("******************************");

            Earbuds earbuds1 = new Earbuds();
            earbuds1.Id = 928;
            earbuds1.earbudsBrand = "Apple";
            earbuds1.eardbudsName = "Apple Airpods 2nd";
            earbuds1.earbudsPrice = 3800;

            Earbuds earbuds2 = new Earbuds();
            earbuds2.Id = 929;
            earbuds2.earbudsBrand = "Apple";
            earbuds2.eardbudsName = "Apple Airpods Pro 1nd";
            earbuds2.earbudsPrice = 8000;

            Earbuds[] earbudsx = new Earbuds[] { earbuds1, earbuds2 };
            for (int i = 0; i < earbudsx.Length; i++)
            {
                Console.WriteLine("Name: " + earbudsx[i].eardbudsName);
            }

            Console.ReadLine();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
    class Arabalar
    {
        public string marka { get; set; }
        public string model { get; set; }
        public int fiyat { get; set; }
    }
    class Laptop
    {
        public string laptopBrand { get; set; }
        public double laptopPrice { get; set; }
        public string laptopMemory { get; set; }
    }
    class Earbuds
    {
        public int  Id { get; set; }
        public string eardbudsName { get; set; }
        public double earbudsPrice { get; set; }
        public string earbudsBrand { get; set; }
    }
}
