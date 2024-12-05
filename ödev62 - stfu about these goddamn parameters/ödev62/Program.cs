using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev62
{
    class EkranIslem
    {
        public void EkranaYaz(params int[] sayılar)
        {
            if (sayılar.Length == 0)
            {
                Console.WriteLine("Parametre olmadığı için metottan çıkılıyor.");
                return;
            }

            Console.WriteLine("Parametreden gelen değerler:");
            foreach (var s in sayılar)
            {
                Console.WriteLine(s);
            }
        }
    }
    internal class Program
    {

        

        static void Main(string[] args)
        {
            EkranIslem ei = new EkranIslem();
            ei.EkranaYaz(3,4,5);
            Console.WriteLine("---------------------------------");
            ei.EkranaYaz();
        }
    }
}
