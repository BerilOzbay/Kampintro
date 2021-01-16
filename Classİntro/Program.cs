using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "R";
            int yas = 23;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Console.WriteLine("Hello World!");

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java#";
            kurs2.KursunEgitmeni = "Kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.KursunEgitmeni = "Berkay";
            kurs3.IzlenmeOrani = 80;

            

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi + " " + kurslar[i].KursunEgitmeni + " " + kurslar[i].IzlenmeOrani);
            }
        }
    }

    class Kurs
    {

        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
