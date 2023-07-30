using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler1 = new string[] {"Ankara","İstanbul","İzmir"}; // 102
            string[] sehirler2 = new string[] { "Adana", "Bursa", "Bolu" }; // 102!
            sehirler1 = sehirler2;
            sehirler2[0] = "Mersin";
            foreach (var item in sehirler1)
            {
                Console.WriteLine(item[0]);
            }





            Console.ReadLine( );
        }
    }
}
