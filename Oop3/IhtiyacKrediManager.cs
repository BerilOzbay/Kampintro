using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac kredi ödeme planı hesaplandı");
        }
    }
}

