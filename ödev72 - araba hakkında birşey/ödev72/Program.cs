using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev72
{

    public abstract class MotorluAraç
    {
        public int MotorHacmi { get; set; }

        public int ModelYılı { get; set; }


        public abstract void Calış();

        public abstract void Dur();
    }

    public class Otomobil : MotorluAraç
    {
        public bool OtomatikVites { get; set; }

        public override void Calış()
        {
            Console.WriteLine("Otomobil çalıştı.");
        }

        public override void Dur()
        {
            Console.WriteLine("Otomobil durdu.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil
            {
                ModelYılı = 2021,
                MotorHacmi = 1400,
                OtomatikVites = true
            };
            oto.Calış();
            oto.Dur();
        }
    }
}
