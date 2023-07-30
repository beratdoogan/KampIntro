using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string> ();
            isimler.Add("Veli");

            List<string> listem = new List<string> { "Mersin","Adana"};
            MyList<int> sayilar = new MyList<int> ();


        }
    }
}
