using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev61
{
    class pehtur
    {
        public int Topla(int sayı1,int sayı2, int sayı3)
        {
            return sayı1 + sayı2 + sayı3;
        }

        public int Toplam(params int[] sayılar)
        {
            int toplam = 0;
            foreach(var gg in sayılar)
            {
                toplam += gg;
            }
            return toplam;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            pehtur tt = new pehtur();
            pehtur bb = new pehtur();
            int toplamb = tt.Topla(3, 5, 6);
            Console.WriteLine("AAA - Sayıların toplamı {0}",toplamb);

            Console.WriteLine("BBB - Sayıların toplamı {0}",bb.Toplam(3));
            Console.WriteLine("BBC - Sayıların toplamı {0}", bb.Toplam(3,4,5));
            Console.WriteLine("BBD - Sayıların toplamı {0}", bb.Toplam(5,1,7,3,4,5));
        }
    }
}
