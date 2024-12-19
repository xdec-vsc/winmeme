using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var öğrenci = new
            {
                Numara = 35,
                Ad = "İbrahim",
                Ortalama = 80.5,
                Adres = new
                {
                    İl = "Nevşehir",
                    İlçe = "Merkez"
                }
            };

            Console.WriteLine("Öğrencini yaşadığı il: "+öğrenci.Adres.İl);
            Console.WriteLine("_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_");
            Console.WriteLine("_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_");
            Console.WriteLine("_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_");


            var öğrenciler = new[]
            {
                new { Numara=100,Ad="Özğe",Ortalama=100},
                new { Numara=200,Ad="yoruldum artık",Ortalama=100},
                new { Numara=300,Ad="AHHHH",Ortalama=80}
            };

            Console.WriteLine("2. öğrencinin adı: " + öğrenciler[1].Ad);
            Console.WriteLine("_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_-=*=-_");

            foreach (var öğrenci2 in öğrenciler)
            {
                Console.WriteLine("Adı: {0}, Otalaması: {1}",öğrenci2.Ad,öğrenci2.Ortalama);
            }
        }
    }
}
