using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Urun urun) // urun foreach deki alyass.Urun ise değişken türü
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }
        public void Kaldır(Urun urun)
        {
            Console.WriteLine(urun.Adi + " sepetten kaldırıldı.");
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}