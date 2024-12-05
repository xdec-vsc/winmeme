using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev70
{
    public class OkulPersoneli
    {
        public string Ad {  get; set; }
        public string Soyad {  get; set; }
    }

    public class Öğretmen : OkulPersoneli
    {
        public string Branş { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Öğretmen ogr = new Öğretmen
            { Ad = "İbrahim", Soyad = "Bilgin", Branş = "BİLİŞİM" };

            OkulPersoneli per = ogr;
        }
    }
}
