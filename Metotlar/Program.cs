using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Koltuk Takımı";
            urun1.Id = 10;
            urun1.Fiyat = 20000;
            urun1.Aciklama = "Bambu koltuk takımı";

            Urun urun2 = new Urun();
            urun2.Adi = "Televizyon";
            urun2.Id = 11;
            urun2.Fiyat = 13000;
            urun2.Aciklama = "Plazma televizyon";

            Urun urun3 = new Urun();
            urun3.Adi = "Avize";
            urun3.Id = 12;
            urun3.Fiyat = 900;
            urun3.Aciklama = "Led avize";


            Urun[] urunler = new Urun[] { urun1, urun2,urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı: " + urun.Adi);
                Console.WriteLine("Ürün Açıklaması : " + urun.Aciklama);
                Console.WriteLine("Ürün Id : " + urun.Id);
                Console.WriteLine("Ürün Fiyatı : " + urun.Fiyat);
                Console.WriteLine("--------------------------------");


            }

            Console.WriteLine("------------------METOTLAR----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Kaldır(urun3);
            sepetManager.Kaldır(urun1);

            Console.WriteLine("----------------------Encapsulation---------------------");

            sepetManager.Ekle2("Apple Iphone 14", "cep telefonu", 24000,12);
            sepetManager.Ekle2("Apple Iphone 14 Pro", "cep telefonu", 30000,21);



            Console.ReadLine();
        }
    }
}

// do not repeat yourself ! 