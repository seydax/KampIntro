using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TasitKrediManager tasitKrediManager = new TasitKrediManager(); alt satırın aynı çıktısını verir
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);//alt satır ile aynı ifade
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());

            List<IKrediManager> kredis = new List<IKrediManager>() { };
            //basvuruManager.KrediOnbilgilendirmeYap(kredis);

        }
    }
}
