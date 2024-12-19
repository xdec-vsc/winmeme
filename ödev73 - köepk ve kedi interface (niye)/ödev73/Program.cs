using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev73
{

    interface HayvanI
    {
        void SesÇıkar();
    }

    interface BeslenI
    {
        void Beslen();
    }

    public class Kedi : HayvanI, BeslenI
    {
        public void SesÇıkar()
        {
            Console.WriteLine("Kedi: miyav");
        }

        public void Beslen()
        {
            Console.WriteLine("Kedi süt içti.");
        }
    }

    public class Köpek : HayvanI, BeslenI
    {
        public void SesÇıkar()
        {
            Console.WriteLine("Köpek: hav hav galiba");
        }

        public void Beslen()
        {
            Console.WriteLine("Köpek et yedi");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.SesÇıkar();
            kedi.Beslen();
            Console.WriteLine("_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_");

            Köpek köpek = new Köpek();
            köpek.SesÇıkar();
            köpek.Beslen();
            Console.WriteLine("_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_");

            HayvanI hayvan1 = kedi;
            HayvanI hayvan2 = köpek;
            hayvan1.SesÇıkar();
            hayvan2.SesÇıkar();
            Console.WriteLine("_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_");

            BeslenI beslen1 = kedi;
            BeslenI beslen2 = köpek;
            beslen1.Beslen();
            beslen2.Beslen();
        }
    }
}
