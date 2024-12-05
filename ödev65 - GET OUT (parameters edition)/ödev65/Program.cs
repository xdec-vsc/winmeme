using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev65
{
    class Kişi
    {
        int yaş = 0;
        string ad = "";
        public Kişi()
        {
            yaş = 19;
            ad = "Mehmet";
            Console.WriteLine("Yapıcı metot çalıştı.");
        }

        public Kişi(int yaş)
        {
            this.yaş = yaş;
            ad = "Ahmet";
            Console.WriteLine("int parametreli yapıcı metot çalıştı.");
        }

        public Kişi(string ad)
        {
            yaş = 19;
            this.ad = ad;
            Console.WriteLine("string parametreli yapıcı metot çalıştı.");
        }

        public Kişi(int yaş, string ad)
        {
            this.yaş = yaş;
            this.ad = ad;
            Console.WriteLine("İki parametreli yapıcı metot çalıştı.");
        }

        public Kişi(string ad, int yaş)
        {
            this.yaş = yaş;
            this.ad = ad;
            Console.WriteLine("İki parametreli yapıcı metot çalıştı.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Kişi k1 = new Kişi();
            Kişi k2 = new Kişi(23);
            Kişi k3 = new Kişi("Filiz");
            Kişi k4 = new Kişi(25,"Süleyman");
            Kişi k5 = new Kişi("Mehmet", 21);
            Console.WriteLine("Program bitti.");
        }
    }
}
