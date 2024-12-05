using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev68
{
    class Matematik
    {
        public void Artır(ref int x)
        {
            x++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik m = new Matematik();
            int a = 100;
            m.Artır(ref a);
            Console.WriteLine("a'nın değeri = {0}",a);
        }
    }
}
