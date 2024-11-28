using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev60
{
    class Sınınfım
    {
        public void Selamla(string ad = "Fatih")
        {
            Console.WriteLine("Merhaba "+ad);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sınınfım gg= new Sınınfım();
            gg.Selamla();
            gg.Selamla("Mehmet");
        }
    }
}
