using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {

        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi:" + " " +  product.Adi);

        }

        public void Add2(string urunAdi, string aciklama, double fiyat)
        {

            Console.WriteLine("Sepete Eklendi:" + " " + urunAdi);
        }

    }
}
