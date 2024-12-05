using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev64
{
    class Kişi
    {
        int yaş;
        string ad;
        public Kişi()
        {
            yaş = 19;
            ad = "Ahmet";
            Console.WriteLine("Yapıcı metot çalıştı.");
        }

        public int Yaş
        {
            get { return yaş; }
        }
        public string Ad
        {
            get { return ad; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı.");
            Kişi k = new Kişi();
            Console.WriteLine("Adı:{0}, Yaşı:{0}",k.Ad,k.Yaş);
            Console.WriteLine("Program bitti.");
        }
    }
}
