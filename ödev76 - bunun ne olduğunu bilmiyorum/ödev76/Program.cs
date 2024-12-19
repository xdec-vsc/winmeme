using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev76
{
    internal class Program
    {

        enum Seviyeler
        {
            ÇokDüşük, //0
            Düşük, //1
            Orta, //2
            Yüksek, //3
            ÇokYüksek //4
        }

        enum Kategoriler
        {
            Bilgisayar=3,
            Mobilya=10,
            Kırtasiye=7,
            Hırdavat, //8
            Otomobil //9
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Seviyeler.Düşük);
            Console.WriteLine((int)Seviyeler.Düşük);

            Kategoriler kat = Kategoriler.Kırtasiye;


            switch (kat)
            {
                case Kategoriler.Bilgisayar:
                    Console.WriteLine("Bilgisayar"); break;
                case Kategoriler.Mobilya:
                    Console.WriteLine("Mobilya"); break;
                case Kategoriler.Kırtasiye:
                    Console.WriteLine("Kırtasiye"); break;
                case Kategoriler.Hırdavat:
                    Console.WriteLine("Hırdavat"); break;
                case Kategoriler.Otomobil:
                    Console.WriteLine("Otomobil"); break;
            }
        }
    }
}
