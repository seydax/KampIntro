using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle (Urun urun)// Urun parametresini atıyor ve urun işlemini yapıyor
        {
            Console.WriteLine("sepete eklendi : "+urun.Adi);
        }

        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int StokAdedi)
        {
            Console.WriteLine("sepete eklendi : " + urunAdi);
        }
    }
}
