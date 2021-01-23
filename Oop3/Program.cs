using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService dataBaseLoggerServices = new DatabaseLoggerServices();
            ILoggerService fileLoggerServices = new FileLoggerServices();

            BasvuruManager basvuruManager = new BasvuruManager();
           basvuruManager.BasvuruYap(ihtiyacKrediManager, dataBaseLoggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
