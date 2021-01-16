using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenci = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Sisteme giris Yapildi");
            }

            else
            {
                Console.WriteLine("Giris yapilmadi");
            }

           
        }
    }
}
