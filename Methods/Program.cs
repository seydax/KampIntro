using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması" ;
            urun1.StokAdedi = 50;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 20;

            Urun[] urunler = new Urun[] { urun1,urun2}; //verileri urunler dizisine atandı

            foreach (Urun urun in urunler)// urunler dizisindeki elemanları urun'e atadı Urun tipindeki
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("-----metodlar----");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //sepetManager'deki Ekle komutunu çağırdık
            sepetManager.Ekle(urun2);

            //encapsulation with StokAdedi
            sepetManager.Ekle2("kiraz","büyük",10,50);//sepetManager'daki Ekle2 komutuna gidip ona göre çalışıyor

        }
    }
}
