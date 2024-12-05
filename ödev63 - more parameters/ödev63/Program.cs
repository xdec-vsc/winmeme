using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev63
{
    class ToplamaIslemi
    {
        public int Topla(int a, int b)
        {
            Console.WriteLine("int parametreli metot çağrılıyor.");
            return a + b;
        }

        public int Topla(params int[] sayılar)
        {
            Console.WriteLine("params parametreli metot çağrılıyor.");
            int toplam = 0;
            foreach (var s in sayılar)
            {
                toplam = toplam + s;
            }
            return toplam;
        }

        public double Topla(double a, double b)
        {
            Console.WriteLine("double parametreli metot çağrılıyor.");
            return a + b;
        }

        public string Topla(string a, string b)
        {
            Console.WriteLine("string parametreli metot çağrılıyor.");
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ToplamaIslemi ti = new ToplamaIslemi();

            Console.WriteLine(ti.Topla(2,5));
            Console.WriteLine(ti.Topla(3,4,5));
            Console.WriteLine(ti.Topla(3.5,5.2));
            Console.WriteLine(ti.Topla("Sağlıcakla ","kalınız"));
        }
    }
}
