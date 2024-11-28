using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev57
{
    public class Üçgen
    {
        public int a;
        public int b;
        public int c;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Üçgen üçgen = new Üçgen();
            üçgen.a = 3;
            üçgen.b = 4;
            üçgen.c = 5;

            Console.WriteLine("Üçgenin a kenarı {0} birim uzunluk",üçgen.a);
            Console.WriteLine("Üçgenin b kenarı {0} birim uzunluk", üçgen.b);
            Console.WriteLine("Üçgenin c kenarı {0} birim uzunluk", üçgen.c);

        }
    }
}
