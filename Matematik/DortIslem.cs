using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class DortIslem
    {
        public void Topla(double sayi1, double sayi2)
        {
            double sonuc = sayi1 + sayi2;
            Console.WriteLine(sayi1 + " + " + sayi2 + " = " + sonuc);
        }
        public void cıkar(double sayi1, double sayi2)
        {
            double sonuc = sayi1 - sayi2;
            Console.WriteLine(sayi1 + " - " + sayi2 + " = " + sonuc);
        }
        public int carp(double sayi1,double sayi2)
        {
            return sayi1 * sayi2;
        }
        public void Bol(double sayi1, double sayi2)
        {
            double sonuc = sayi1 / sayi2;
            Console.WriteLine(sayi1 + " / " + sayi2 + " = " + sonuc);
        }
        public void BuyukMuKucukMu (double sayi1,double sayi2)
        {
            if (sayi1 < sayi2)
            {
                Console.WriteLine(sayi2 + " " + sayi1 + "'den daha büyük");
            }else if(sayi1 == sayi2){
                Console.WriteLine("İki sayı birbirine eşit");
            }
            else
            {
                Console.WriteLine(sayi1 + " " + sayi2 + "'den daha büyük");
            }
        
        }


    }
}
