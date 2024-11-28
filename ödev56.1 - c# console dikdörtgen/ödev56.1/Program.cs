using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev56._1
{
    class Dikdörtgen
    {
        private int a, b;

        public Dikdörtgen(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int AlanHesapla()
        {
            return a * b;
        }
        public int ÇevreHesapla()
        {
            return 2 * (a + b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen d = new Dikdörtgen(3, 4);

            Console.WriteLine("dikdörtgenin alanı {0}",d.AlanHesapla());
            Console.WriteLine("dikdörtgenin çevresi {0} ",d.ÇevreHesapla());
        }
    }
}