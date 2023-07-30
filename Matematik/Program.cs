using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Program
    {
        public static void Main(string[] args)
        {
            DortIslem ıslem = new DortIslem();
            ıslem.Topla(10, 20);
            ıslem.cıkar(90, 70);
            ıslem.Bol(20, 10);
            ıslem.carp(9, 6);
            ıslem.BuyukMuKucukMu(10, 10);
            ıslem.BuyukMuKucukMu(90, 20);

            int krediFaizOrani = ıslem.carp(4, 7);




            Console.ReadLine();
        }
    }
}
