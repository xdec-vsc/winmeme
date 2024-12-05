using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev67
{
    class SayıTutucu
    {
        public int A { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = sayı1;
            sayı2 = 50;
            Console.WriteLine("sayı1={0}",sayı1);
            Console.WriteLine("sayı2={0}",sayı2);
            SayıTutucu st1 = new SayıTutucu();
            st1.A = 10;
            SayıTutucu st2 = st1;
            st1.A = 70;
            Console.WriteLine("st1.A değer,: {0}",st1.A);
            Console.WriteLine("st2.A değer: {0}",st2.A);
        }
    }
}
