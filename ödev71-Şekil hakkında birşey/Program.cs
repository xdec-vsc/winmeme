using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev71
{
    public class Şekil
    {
        public const double pi = 3.14;
        protected double x, y;

        public Şekil()
        {

        }

        public Şekil(double x, double y)
        {
            this.x = x; this.y = y;
        }

        public virtual double AlanıHesapla()
        {
            return x * y;
        }

        public virtual void BilgiYazdır()
        {
            Console.WriteLine("x="+x+" ve y="+y);
        }
    }

    public class Daire : Şekil
    {
        public Daire(double r) : base(r, 0)
        {

        }

        public override double AlanıHesapla()
        {
            return pi * x * x;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Şekil i = new Şekil(3, 4);
            i.BilgiYazdır();
            Console.WriteLine("Şekil alanı: "+i.AlanıHesapla());
            Console.WriteLine("------------------------------------");
            Daire d = new Daire(1);
            d.BilgiYazdır();
            Console.WriteLine("Daire Alanı: {0:N2}",d.AlanıHesapla());
        }
    }
}
