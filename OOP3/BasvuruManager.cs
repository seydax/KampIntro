using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); tüm başvurular konut kredisi üzerinden hesaplanıyor.
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnbilgilendirmeYap(List<IKrediManager> kredis)
        {
            foreach (var kredi in kredis)
            {
                kredi.Hesapla();//listedeki her kredinin hesabını yap
            }
        }
    }
}
