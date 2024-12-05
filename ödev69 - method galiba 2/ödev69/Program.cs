using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev69
{
    class Matematik
    {
        public void Artır(out int x)
        {
            x=123;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik m = new Matematik();
            int a = 100;
            m.Artır(out a);
            Console.WriteLine("a'nın değeri = {0}", a);
        }
    }
}
