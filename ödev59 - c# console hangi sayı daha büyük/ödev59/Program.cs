using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev59
{
    class sayıbulucu
    {
        public int hangisibüyük(int sayı1, int sayı2)
        {
            int sonuç;
            if (sayı1 < sayı2)
            {
                sonuç = sayı2;
            }
            else
            {
                sonuç = sayı1;
            }
            return sonuç;
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            sayıbulucu sb = new sayıbulucu();
            int a = 100;
            int b = 225;
            int sonuç = sb.hangisibüyük(a, b);
            Console.WriteLine("{0} sayısı daha büyük",sonuç);
        }
    }
}
