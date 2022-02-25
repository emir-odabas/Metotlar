using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            */

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());
            
            // basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            







        }
    }
}
