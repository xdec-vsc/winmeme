using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev58
{
    public class Üçgen
    {
        int a;
        int b;
        int c;

        public int A
        {
            get { return a; }
            set { if (value <= 0) Console.WriteLine("Hatalı bilgi");
                else a = value;}
        }

        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0) Console.WriteLine("Hatalı bilgi");
                else b = value;
            }
        }

        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0) Console.WriteLine("Hatalı bilgi");
                else c = value;
            }
        }

        public int Çevre
        {
            get
            {
                return a + b + c;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Üçgen üçgen = new Üçgen();
            üçgen.A = 3;
            üçgen.B = 4;
            üçgen.C = 5;

            Console.WriteLine("Üçgenin A kenarı {0} birim uzunluğunda", üçgen.A);
            Console.WriteLine("Üçgenin B kenarı {0} birim uzunluğunda", üçgen.B);
            Console.WriteLine("Üçgenin C kenarı {0} birim uzunluğunda", üçgen.C);

            Console.WriteLine("Üçgenin çevres, {0} birim uzunluğunda", üçgen.Çevre);
        }
    }
}
